
using System;
namespace DataService.Model
{
	/// <summary>
	/// friendshiplink:友情连接实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class friendshiplink
	{
		public friendshiplink()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _pic;
		private string _url;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 图片路径
		/// </summary>
		public string Pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		/// <summary>
		/// 链接地址
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}

