/**  版本信息模板在安装目录下，可自行修改。
* auction.cs
*
* 功 能： N/A
* 类 名： auction
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:51   N/A    初版
*
* Copyright (c) 2012 DataService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DataService.DBUtility;//Please add references
namespace DataService.DAL
{
	/// <summary>
	/// 数据访问类:auction
	/// </summary>
	public partial class auction
	{
		public auction()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string AID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from auction");
			strSql.Append(" where AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = AID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.auction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into auction(");
			strSql.Append("AID,Name,Type,Time,Address,PrivateLaw,CourtName,ShowTime,Announcement)");
			strSql.Append(" values (");
			strSql.Append("@AID,@Name,@Type,@Time,@Address,@PrivateLaw,@CourtName,@ShowTime,@Announcement)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AID", MySqlDbType.VarChar,64),
					new MySqlParameter("@Name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Type", MySqlDbType.VarChar,255),
					new MySqlParameter("@Time", MySqlDbType.DateTime),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@PrivateLaw", MySqlDbType.Bit),
					new MySqlParameter("@CourtName", MySqlDbType.VarChar,255),
					new MySqlParameter("@ShowTime", MySqlDbType.DateTime),
					new MySqlParameter("@Announcement", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.AID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Type;
			parameters[3].Value = model.Time;
			parameters[4].Value = model.Address;
			parameters[5].Value = model.PrivateLaw;
			parameters[6].Value = model.CourtName;
			parameters[7].Value = model.ShowTime;
			parameters[8].Value = model.Announcement;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataService.Model.auction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update auction set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Type=@Type,");
			strSql.Append("Time=@Time,");
			strSql.Append("Address=@Address,");
			strSql.Append("PrivateLaw=@PrivateLaw,");
			strSql.Append("CourtName=@CourtName,");
			strSql.Append("ShowTime=@ShowTime,");
			strSql.Append("Announcement=@Announcement");
			strSql.Append(" where AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Type", MySqlDbType.VarChar,255),
					new MySqlParameter("@Time", MySqlDbType.DateTime),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@PrivateLaw", MySqlDbType.Bit),
					new MySqlParameter("@CourtName", MySqlDbType.VarChar,255),
					new MySqlParameter("@ShowTime", MySqlDbType.DateTime),
					new MySqlParameter("@Announcement", MySqlDbType.VarChar,255),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Type;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.PrivateLaw;
			parameters[5].Value = model.CourtName;
			parameters[6].Value = model.ShowTime;
			parameters[7].Value = model.Announcement;
			parameters[8].Value = model.AID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string AID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from auction ");
			strSql.Append(" where AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = AID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string AIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from auction ");
			strSql.Append(" where AID in ("+AIDlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.auction GetModel(string AID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AID,Name,Type,Time,Address,PrivateLaw,CourtName,ShowTime,Announcement from auction ");
			strSql.Append(" where AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = AID;

			DataService.Model.auction model=new DataService.Model.auction();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.auction DataRowToModel(DataRow row)
		{
			DataService.Model.auction model=new DataService.Model.auction();
			if (row != null)
			{
				if(row["AID"]!=null)
				{
					model.AID=row["AID"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["PrivateLaw"]!=null && row["PrivateLaw"].ToString()!="")
				{
					if((row["PrivateLaw"].ToString()=="1")||(row["PrivateLaw"].ToString().ToLower()=="true"))
					{
						model.PrivateLaw=true;
					}
					else
					{
						model.PrivateLaw=false;
					}
				}
				if(row["CourtName"]!=null)
				{
					model.CourtName=row["CourtName"].ToString();
				}
				if(row["ShowTime"]!=null && row["ShowTime"].ToString()!="")
				{
					model.ShowTime=DateTime.Parse(row["ShowTime"].ToString());
				}
				if(row["Announcement"]!=null)
				{
					model.Announcement=row["Announcement"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AID,Name,Type,Time,Address,PrivateLaw,CourtName,ShowTime,Announcement ");
			strSql.Append(" FROM auction ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM auction ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.AID desc");
			}
			strSql.Append(")AS Row, T.*  from auction T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "auction";
			parameters[1].Value = "AID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

