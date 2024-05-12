﻿using System;
using ProtoBuf;
using System.Collections.Generic;
using GameFrameX.Network.Runtime;

namespace Hotfix.Proto
{
	/// <summary>
	/// 返回码
	/// </summary>
	public enum ResultCode
	{
		/// <summary>
		/// 成功
		/// </summary>
		Success = 0, 
		/// <summary>
		/// 失败
		/// </summary>
		Failed = 1, 
	}

	/// <summary>
	/// 
	/// </summary>
	public enum PhoneType
	{
		/// <summary>
		/// 手机
		/// </summary>
		MOBILE = 0, 
		/// <summary>
		/// 
		/// </summary>
		HOME = 1, 
		/// <summary>
		/// 工作号码
		/// </summary>
		WORK = 2, 
	}

	/// <summary>
	/// 玩家基础信息
	/// </summary>
	[ProtoContract]
	public partial class UserInfo
	{
		/// <summary>
		/// 角色名
		/// </summary>
		[ProtoMember(1)]
		public string RoleName { get; set; }

		/// <summary>
		/// 角色ID
		/// </summary>
		[ProtoMember(2)]
		public long RoleId { get; set; }

		/// <summary>
		/// 角色等级
		/// </summary>
		[ProtoMember(3)]
		public int Level { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		[ProtoMember(4)]
		public long CreateTime { get; set; }

		/// <summary>
		/// vip等级
		/// </summary>
		[ProtoMember(5)]
		public int VipLevel { get; set; }

	}

	/// <summary>
	/// 
	/// </summary>
	[ProtoContract]
	public partial class PhoneNumber
	{
		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(1)]
		public string number { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(2)]
		public PhoneType type { get; set; }

	}

	/// <summary>
	/// 
	/// </summary>
	[ProtoContract]
	public partial class Person
	{
		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(1)]
		public string name { get; set; }

		/// <summary>
		/// Unique ID number for this person.
		/// </summary>
		[ProtoMember(2)]
		public int id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(3)]
		public string email { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(4)]
		public List<PhoneNumber> phones = new List<PhoneNumber>();

	}

	/// <summary>
	/// Our address book file is just one of these.
	/// </summary>
	[ProtoContract]
	public partial class AddressBook
	{
		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(1)]
		public List<Person> people = new List<Person>();

	}

}
