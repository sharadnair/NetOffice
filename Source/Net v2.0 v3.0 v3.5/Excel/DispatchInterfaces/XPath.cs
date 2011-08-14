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
	/// DispatchInterface XPath SupportByLibrary Excel, 11,12,14
	///</summary>
	[SupportByLibrary("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XPath : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(XPath);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XPath(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XPath(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XPath(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XPath()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
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
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
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
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
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
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
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
		public string Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.XmlMap Map
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Map", paramsArray);
				NetOffice.ExcelApi.XmlMap newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.XmlMap;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public bool Repeating
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Repeating", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="XPath">string XPath</param>
		/// <param name="SelectionNamespace">optional object SelectionNamespace</param>
		/// <param name="Repeating">optional object Repeating</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public void SetValue(NetOffice.ExcelApi.XmlMap map, string xPath, object selectionNamespace, object repeating)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, xPath, selectionNamespace, repeating);
			Invoker.Method(this, "SetValue", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="XPath">string XPath</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public void SetValue(NetOffice.ExcelApi.XmlMap map, string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(map, xPath);
			Invoker.Method(this, "SetValue", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}