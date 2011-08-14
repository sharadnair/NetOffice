//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface SmartTagAction SupportByLibrary Excel, 10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartTagAction : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SmartTagAction);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagAction(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagAction(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagAction(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartTagAction()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Enums.XlSmartTagControlType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSmartTagControlType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public bool PresentInPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresentInPane", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public bool ExpandHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExpandHelp", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExpandHelp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public bool CheckboxState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CheckboxState", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CheckboxState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public string TextboxText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextboxText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextboxText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 ListSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListSelection", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 RadioGroupSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RadioGroupSelection", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RadioGroupSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public COMObject ActiveXControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveXControl", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}