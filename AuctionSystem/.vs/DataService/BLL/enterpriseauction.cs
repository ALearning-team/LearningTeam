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
using System.Collections.Generic;

using DataService.Model;
namespace DataService.BLL
{
	/// <summary>
	/// enterpriseauction
	/// </summary>
	public partial class enterpriseauction
	{
		private readonly DataService.DAL.enterpriseauction dal=new DataService.DAL.enterpriseauction();
		public enterpriseauction()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string EID,string AID)
		{
			return dal.Exists(EID,AID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.enterpriseauction model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataService.Model.enterpriseauction model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string EID,string AID)
		{
			
			return dal.Delete(EID,AID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.enterpriseauction GetModel(string EID,string AID)
		{
			
			return dal.GetModel(EID,AID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public DataService.Model.enterpriseauction GetModelByCache(string EID,string AID)
		//{
			
		//	string CacheKey = "enterpriseauctionModel-" + EID+AID;
		//	object objModel = DataService.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(EID,AID);
		//			if (objModel != null)
		//			{
		//				int ModelCache = DataService.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				DataService.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (DataService.Model.enterpriseauction)objModel;
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
		public List<DataService.Model.enterpriseauction> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataService.Model.enterpriseauction> DataTableToList(DataTable dt)
		{
			List<DataService.Model.enterpriseauction> modelList = new List<DataService.Model.enterpriseauction>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DataService.Model.enterpriseauction model;
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

