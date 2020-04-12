/**  版本信息模板在安装目录下，可自行修改。
* enterprise.cs
*
* 功 能： N/A
* 类 名： enterprise
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:53   N/A    初版
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
	/// 数据访问类:enterprise
	/// </summary>
	public partial class enterprise
	{
		public enterprise()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string EID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from enterprise");
			strSql.Append(" where EID=@EID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.enterprise model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into enterprise(");
			strSql.Append("EID,UserName,EName,CreditCode,Logo,Phone,Address,Abstract)");
			strSql.Append(" values (");
			strSql.Append("@EID,@UserName,@EName,@CreditCode,@Logo,@Phone,@Address,@Abstract)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EName", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreditCode", MySqlDbType.VarChar,64),
					new MySqlParameter("@Logo", MySqlDbType.VarChar,255),
					new MySqlParameter("@Phone", MySqlDbType.VarChar,12),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@Abstract", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.EID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.EName;
			parameters[3].Value = model.CreditCode;
			parameters[4].Value = model.Logo;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Abstract;

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
		public bool Update(DataService.Model.enterprise model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update enterprise set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("EName=@EName,");
			strSql.Append("CreditCode=@CreditCode,");
			strSql.Append("Logo=@Logo,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address,");
			strSql.Append("Abstract=@Abstract");
			strSql.Append(" where EID=@EID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@UserName", MySqlDbType.VarChar,255),
					new MySqlParameter("@EName", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreditCode", MySqlDbType.VarChar,64),
					new MySqlParameter("@Logo", MySqlDbType.VarChar,255),
					new MySqlParameter("@Phone", MySqlDbType.VarChar,12),
					new MySqlParameter("@Address", MySqlDbType.VarChar,255),
					new MySqlParameter("@Abstract", MySqlDbType.VarChar,255),
					new MySqlParameter("@EID", MySqlDbType.VarChar,64)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.EName;
			parameters[2].Value = model.CreditCode;
			parameters[3].Value = model.Logo;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.Abstract;
			parameters[7].Value = model.EID;

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
		public bool Delete(string EID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from enterprise ");
			strSql.Append(" where EID=@EID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;

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
		public bool DeleteList(string EIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from enterprise ");
			strSql.Append(" where EID in ("+EIDlist + ")  ");
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
		public DataService.Model.enterprise GetModel(string EID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EID,UserName,EName,CreditCode,Logo,Phone,Address,Abstract from enterprise ");
			strSql.Append(" where EID=@EID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EID", MySqlDbType.VarChar,64)			};
			parameters[0].Value = EID;

			DataService.Model.enterprise model=new DataService.Model.enterprise();
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
		public DataService.Model.enterprise DataRowToModel(DataRow row)
		{
			DataService.Model.enterprise model=new DataService.Model.enterprise();
			if (row != null)
			{
				if(row["EID"]!=null)
				{
					model.EID=row["EID"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["EName"]!=null)
				{
					model.EName=row["EName"].ToString();
				}
				if(row["CreditCode"]!=null)
				{
					model.CreditCode=row["CreditCode"].ToString();
				}
				if(row["Logo"]!=null)
				{
					model.Logo=row["Logo"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Abstract"]!=null)
				{
					model.Abstract=row["Abstract"].ToString();
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
			strSql.Append("select EID,UserName,EName,CreditCode,Logo,Phone,Address,Abstract ");
			strSql.Append(" FROM enterprise ");
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
			strSql.Append("select count(1) FROM enterprise ");
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
				strSql.Append("order by T.EID desc");
			}
			strSql.Append(")AS Row, T.*  from enterprise T ");
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
			parameters[0].Value = "enterprise";
			parameters[1].Value = "EID";
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

