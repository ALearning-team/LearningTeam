/**  版本信息模板在安装目录下，可自行修改。
* enterpriseauction.cs
*
* 功 能： N/A
* 类 名： enterpriseauction
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:54   N/A    初版
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
	/// 数据访问类:enterpriseauction
	/// </summary>
	public partial class enterpriseauction
	{
		public enterpriseauction()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string EID,string AID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from enterpriseauction");
			strSql.Append(" where EID=@EID and AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;
			parameters[1].Value = AID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.enterpriseauction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into enterpriseauction(");
			strSql.Append("EID,AID)");
			strSql.Append(" values (");
			strSql.Append("@EID,@AID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)};
			parameters[0].Value = model.EID;
			parameters[1].Value = model.AID;

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
		public bool Update(DataService.Model.enterpriseauction model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update enterpriseauction set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("EID=@EID,");
			strSql.Append("AID=@AID");
			strSql.Append(" where EID=@EID and AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)};
			parameters[0].Value = model.EID;
			parameters[1].Value = model.AID;

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
		public bool Delete(string EID,string AID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from enterpriseauction ");
			strSql.Append(" where EID=@EID and AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;
			parameters[1].Value = AID;

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
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.enterpriseauction GetModel(string EID,string AID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EID,AID from enterpriseauction ");
			strSql.Append(" where EID=@EID and AID=@AID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@AID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;
			parameters[1].Value = AID;

			DataService.Model.enterpriseauction model=new DataService.Model.enterpriseauction();
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
		public DataService.Model.enterpriseauction DataRowToModel(DataRow row)
		{
			DataService.Model.enterpriseauction model=new DataService.Model.enterpriseauction();
			if (row != null)
			{
				if(row["EID"]!=null)
				{
					model.EID=row["EID"].ToString();
				}
				if(row["AID"]!=null)
				{
					model.AID=row["AID"].ToString();
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
			strSql.Append("select EID,AID ");
			strSql.Append(" FROM enterpriseauction ");
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
			strSql.Append("select count(1) FROM enterpriseauction ");
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
			strSql.Append(")AS Row, T.*  from enterpriseauction T ");
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
			parameters[0].Value = "enterpriseauction";
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

