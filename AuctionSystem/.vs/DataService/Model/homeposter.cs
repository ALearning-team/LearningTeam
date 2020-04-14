
using System;
namespace DataService.Model
{
	/// <summary>
	/// homeposter:首页海报实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class homeposter
	{
		public homeposter()
		{}
		#region Model
		private int _id;
		private bool _state;
		private string _pic;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 使用状态（只能一张图片使用）
		/// </summary>
		public bool State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 图片路径
		/// </summary>
		public string Pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		#endregion Model

	}
}

