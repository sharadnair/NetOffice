//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotRowMember SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotRowMember : PivotAxisMember
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PivotRowMember);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRowMember()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotView View
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "View", paramsArray);
				NetOffice.OWC10Api.PivotView newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotView;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMembers ChildMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildMembers", paramsArray);
				NetOffice.OWC10Api.PivotMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMember ParentMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentMember", paramsArray);
				NetOffice.OWC10Api.PivotMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotMember get_FindMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, format);
			object returnItem = Invoker.PropertyGet(this, "FindMember", paramsArray);
			NetOffice.OWC10Api.PivotMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public string UniqueName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UniqueName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotField Field
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Field", paramsArray);
				NetOffice.OWC10Api.PivotField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByLibrary("OWC10", 1)]
		public string get_Path(NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(format);
			object returnItem = Invoker.PropertyGet(this, "Path", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public object TimeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TimeValue", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public bool IsValid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsValid", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum CustomGroupType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomGroupType", paramsArray);
				return (NetOffice.OWC10Api.Enums.PivotMemberCustomGroupTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMembers ChildRowMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildRowMembers", paramsArray);
				NetOffice.OWC10Api.PivotRowMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMember ParentRowMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentRowMember", paramsArray);
				NetOffice.OWC10Api.PivotRowMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMember get_FindRowMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, format);
			object returnItem = Invoker.PropertyGet(this, "FindRowMember", paramsArray);
			NetOffice.OWC10Api.PivotRowMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMember TotalRowMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalRowMember", paramsArray);
				NetOffice.OWC10Api.PivotRowMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 TotalRowHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalRowHeight", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TotalRowHeight", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}