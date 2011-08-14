//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface Permission SupportByLibrary Office, 11,12,14
	///</summary>
	[SupportByLibrary("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Permission : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Permission);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Permission(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Permission(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Permission(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Permission()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Office", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.UserPermission this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.UserPermission newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.UserPermission;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public bool EnableTrustedBrowser
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableTrustedBrowser", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableTrustedBrowser", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public string RequestPermissionURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RequestPermissionURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RequestPermissionURL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public string PolicyName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PolicyName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public string PolicyDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PolicyDescription", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public bool StoreLicenses
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StoreLicenses", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StoreLicenses", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public string DocumentAuthor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DocumentAuthor", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DocumentAuthor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public bool PermissionFromPolicy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PermissionFromPolicy", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="UserId">string UserId</param>
		/// <param name="Permission">optional object Permission</param>
		/// <param name="ExpirationDate">optional object ExpirationDate</param>
		[SupportByLibrary("Office", 11,12,14)]
		public NetOffice.OfficeApi.UserPermission Add(string userId, object permission, object expirationDate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(userId, permission, expirationDate);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.UserPermission newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.UserPermission;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="UserId">string UserId</param>
		[SupportByLibrary("Office", 11,12,14)]
		public NetOffice.OfficeApi.UserPermission Add(string userId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(userId);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.UserPermission newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.UserPermission;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Office", 11,12,14)]
		public void ApplyPolicy(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "ApplyPolicy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public void RemoveAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveAll", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Office", 11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}