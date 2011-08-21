//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface View SupportByLibrary Outlook, 10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class View : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(View);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
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
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public string Language
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Language", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Language", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public bool LockUserChanges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockUserChanges", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockUserChanges", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlViewSaveOption SaveOption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SaveOption", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlViewSaveOption)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public bool Standard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Standard", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlViewType ViewType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewType", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlViewType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "XML", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Apply()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Apply", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="SaveOption">NetOffice.OutlookApi.Enums.OlViewSaveOption SaveOption</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.View Copy(string name, NetOffice.OutlookApi.Enums.OlViewSaveOption saveOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, saveOption);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.OutlookApi.View newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.View.LateBindingApiWrapperType) as NetOffice.OutlookApi.View;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="Date">DateTime Date</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void GoToDate(DateTime date)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(date);
			Invoker.Method(this, "GoToDate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}