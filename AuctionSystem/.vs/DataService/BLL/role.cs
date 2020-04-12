/**  版本信息模板在安装目录下，可自行修改。
* role.cs
*
* 功 能： N/A
* 类 名： role
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:59   N/A    初版
*
* Copyright (c) 2012 DataService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using DataService.Model;
namespace DataService.BLL
{
	/// <summary>
	/// role
	/// </summary>
	public partial class role
	{
		private readonly DataService.DAL.role dal=new DataService.DAL.role();
		public role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RoleID)
		{
			return dal.Exists(RoleID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.role model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataService.Model.role model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int RoleID)
		{
			
			return dal.Delete(RoleID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string RoleIDlist )
		{
			return dal.DeleteList(RoleIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.role GetModel(int RoleID)
		{
			
			return dal.GetModel(RoleID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public DataService.Model.role GetModelByCache(int RoleID)
		//{
			
		//	string CacheKey = "roleModel-" + RoleID;
		//	object objModel = DataService.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(RoleID);
		//			if (objModel != null)
		//			{
		//				int ModelCache = DataService.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				DataService.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (DataService.Model.role)objModel;
		//}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataService.Model.role> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataService.Model.role> DataTableToList(DataTable dt)
		{
			List<DataService.Model.role> modelList = new List<DataService.Model.role>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DataService.Model.role model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

