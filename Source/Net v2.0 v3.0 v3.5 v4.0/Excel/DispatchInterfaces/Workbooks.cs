//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface Workbooks SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Workbooks : COMObject ,IEnumerable
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
                    _type = typeof(Workbooks);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbooks(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbooks(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbooks(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbooks() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Workbooks(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.Workbook this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Workbook get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Template">optional object Template</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Workbook Add(object template)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(template);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Workbook Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="UpdateLinks">optional object UpdateLinks</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="Password">optional object Password</param>
		/// <param name="WriteResPassword">optional object WriteResPassword</param>
		/// <param name="IgnoreReadOnlyRecommended">optional object IgnoreReadOnlyRecommended</param>
		/// <param name="Origin">optional object Origin</param>
		/// <param name="Delimiter">optional object Delimiter</param>
		/// <param name="Editable">optional object Editable</param>
		/// <param name="Notify">optional object Notify</param>
		/// <param name="Converter">optional object Converter</param>
		/// <param name="AddToMru">optional object AddToMru</param>
		[SupportByLibrary("Excel", 9)]
		public NetOffice.ExcelApi.Workbook Open(string filename, object updateLinks, object readOnly, object format, object password, object writeResPassword, object ignoreReadOnlyRecommended, object origin, object delimiter, object editable, object notify, object converter, object addToMru)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, updateLinks, readOnly, format, password, writeResPassword, ignoreReadOnlyRecommended, origin, delimiter, editable, notify, converter, addToMru);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="UpdateLinks">optional object UpdateLinks</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="Password">optional object Password</param>
		/// <param name="WriteResPassword">optional object WriteResPassword</param>
		/// <param name="IgnoreReadOnlyRecommended">optional object IgnoreReadOnlyRecommended</param>
		/// <param name="Origin">optional object Origin</param>
		/// <param name="Delimiter">optional object Delimiter</param>
		/// <param name="Editable">optional object Editable</param>
		/// <param name="Notify">optional object Notify</param>
		/// <param name="Converter">optional object Converter</param>
		/// <param name="AddToMru">optional object AddToMru</param>
		/// <param name="Local">optional object Local</param>
		/// <param name="CorruptLoad">optional object CorruptLoad</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook Open(string filename, object updateLinks, object readOnly, object format, object password, object writeResPassword, object ignoreReadOnlyRecommended, object origin, object delimiter, object editable, object notify, object converter, object addToMru, object local, object corruptLoad)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, updateLinks, readOnly, format, password, writeResPassword, ignoreReadOnlyRecommended, origin, delimiter, editable, notify, converter, addToMru, local, corruptLoad);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Workbook Open(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		/// <param name="ConsecutiveDelimiter">optional object ConsecutiveDelimiter</param>
		/// <param name="Tab">optional object Tab</param>
		/// <param name="Semicolon">optional object Semicolon</param>
		/// <param name="Comma">optional object Comma</param>
		/// <param name="Space">optional object Space</param>
		/// <param name="Other">optional object Other</param>
		/// <param name="OtherChar">optional object OtherChar</param>
		/// <param name="FieldInfo">optional object FieldInfo</param>
		/// <param name="TextVisualLayout">optional object TextVisualLayout</param>
		[SupportByLibrary("Excel", 9)]
		public void _OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier, object consecutiveDelimiter, object tab, object semicolon, object comma, object space, object other, object otherChar, object fieldInfo, object textVisualLayout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier, consecutiveDelimiter, tab, semicolon, comma, space, other, otherChar, fieldInfo, textVisualLayout);
			Invoker.Method(this, "_OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		/// <param name="ConsecutiveDelimiter">optional object ConsecutiveDelimiter</param>
		/// <param name="Tab">optional object Tab</param>
		/// <param name="Semicolon">optional object Semicolon</param>
		/// <param name="Comma">optional object Comma</param>
		/// <param name="Space">optional object Space</param>
		/// <param name="Other">optional object Other</param>
		/// <param name="OtherChar">optional object OtherChar</param>
		/// <param name="FieldInfo">optional object FieldInfo</param>
		/// <param name="TextVisualLayout">optional object TextVisualLayout</param>
		/// <param name="DecimalSeparator">optional object DecimalSeparator</param>
		/// <param name="ThousandsSeparator">optional object ThousandsSeparator</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void _OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier, object consecutiveDelimiter, object tab, object semicolon, object comma, object space, object other, object otherChar, object fieldInfo, object textVisualLayout, object decimalSeparator, object thousandsSeparator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier, consecutiveDelimiter, tab, semicolon, comma, space, other, otherChar, fieldInfo, textVisualLayout, decimalSeparator, thousandsSeparator);
			Invoker.Method(this, "_OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public void _OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier);
			Invoker.Method(this, "_OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		/// <param name="ConsecutiveDelimiter">optional object ConsecutiveDelimiter</param>
		/// <param name="Tab">optional object Tab</param>
		/// <param name="Semicolon">optional object Semicolon</param>
		/// <param name="Comma">optional object Comma</param>
		/// <param name="Space">optional object Space</param>
		/// <param name="Other">optional object Other</param>
		/// <param name="OtherChar">optional object OtherChar</param>
		/// <param name="FieldInfo">optional object FieldInfo</param>
		/// <param name="TextVisualLayout">optional object TextVisualLayout</param>
		/// <param name="DecimalSeparator">optional object DecimalSeparator</param>
		/// <param name="ThousandsSeparator">optional object ThousandsSeparator</param>
		[SupportByLibrary("Excel", 9)]
		public void OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier, object consecutiveDelimiter, object tab, object semicolon, object comma, object space, object other, object otherChar, object fieldInfo, object textVisualLayout, object decimalSeparator, object thousandsSeparator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier, consecutiveDelimiter, tab, semicolon, comma, space, other, otherChar, fieldInfo, textVisualLayout, decimalSeparator, thousandsSeparator);
			Invoker.Method(this, "OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		/// <param name="ConsecutiveDelimiter">optional object ConsecutiveDelimiter</param>
		/// <param name="Tab">optional object Tab</param>
		/// <param name="Semicolon">optional object Semicolon</param>
		/// <param name="Comma">optional object Comma</param>
		/// <param name="Space">optional object Space</param>
		/// <param name="Other">optional object Other</param>
		/// <param name="OtherChar">optional object OtherChar</param>
		/// <param name="FieldInfo">optional object FieldInfo</param>
		/// <param name="TextVisualLayout">optional object TextVisualLayout</param>
		/// <param name="DecimalSeparator">optional object DecimalSeparator</param>
		/// <param name="ThousandsSeparator">optional object ThousandsSeparator</param>
		/// <param name="TrailingMinusNumbers">optional object TrailingMinusNumbers</param>
		/// <param name="Local">optional object Local</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier, object consecutiveDelimiter, object tab, object semicolon, object comma, object space, object other, object otherChar, object fieldInfo, object textVisualLayout, object decimalSeparator, object thousandsSeparator, object trailingMinusNumbers, object local)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier, consecutiveDelimiter, tab, semicolon, comma, space, other, otherChar, fieldInfo, textVisualLayout, decimalSeparator, thousandsSeparator, trailingMinusNumbers, local);
			Invoker.Method(this, "OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public void OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier);
			Invoker.Method(this, "OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="UpdateLinks">optional object UpdateLinks</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="Password">optional object Password</param>
		/// <param name="WriteResPassword">optional object WriteResPassword</param>
		/// <param name="IgnoreReadOnlyRecommended">optional object IgnoreReadOnlyRecommended</param>
		/// <param name="Origin">optional object Origin</param>
		/// <param name="Delimiter">optional object Delimiter</param>
		/// <param name="Editable">optional object Editable</param>
		/// <param name="Notify">optional object Notify</param>
		/// <param name="Converter">optional object Converter</param>
		/// <param name="AddToMru">optional object AddToMru</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook _Open(string filename, object updateLinks, object readOnly, object format, object password, object writeResPassword, object ignoreReadOnlyRecommended, object origin, object delimiter, object editable, object notify, object converter, object addToMru)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, updateLinks, readOnly, format, password, writeResPassword, ignoreReadOnlyRecommended, origin, delimiter, editable, notify, converter, addToMru);
			object returnItem = Invoker.MethodReturn(this, "_Open", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook _Open(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "_Open", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		/// <param name="ConsecutiveDelimiter">optional object ConsecutiveDelimiter</param>
		/// <param name="Tab">optional object Tab</param>
		/// <param name="Semicolon">optional object Semicolon</param>
		/// <param name="Comma">optional object Comma</param>
		/// <param name="Space">optional object Space</param>
		/// <param name="Other">optional object Other</param>
		/// <param name="OtherChar">optional object OtherChar</param>
		/// <param name="FieldInfo">optional object FieldInfo</param>
		/// <param name="TextVisualLayout">optional object TextVisualLayout</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void __OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier, object consecutiveDelimiter, object tab, object semicolon, object comma, object space, object other, object otherChar, object fieldInfo, object textVisualLayout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier, consecutiveDelimiter, tab, semicolon, comma, space, other, otherChar, fieldInfo, textVisualLayout);
			Invoker.Method(this, "__OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Origin">object Origin</param>
		/// <param name="StartRow">object StartRow</param>
		/// <param name="DataType">object DataType</param>
		/// <param name="TextQualifier">NetOffice.ExcelApi.Enums.XlTextQualifier TextQualifier</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void __OpenText(string filename, object origin, object startRow, object dataType, NetOffice.ExcelApi.Enums.XlTextQualifier textQualifier)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, origin, startRow, dataType, textQualifier);
			Invoker.Method(this, "__OpenText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="CommandText">optional object CommandText</param>
		/// <param name="CommandType">optional object CommandType</param>
		/// <param name="BackgroundQuery">optional object BackgroundQuery</param>
		/// <param name="ImportDataAs">optional object ImportDataAs</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook OpenDatabase(string filename, object commandText, object commandType, object backgroundQuery, object importDataAs)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, commandText, commandType, backgroundQuery, importDataAs);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook OpenDatabase(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void CheckOut(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			Invoker.Method(this, "CheckOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public bool CanCheckOut(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "CanCheckOut", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 10
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Stylesheets">optional object Stylesheets</param>
		[SupportByLibrary("Excel", 10)]
		public NetOffice.ExcelApi.Workbook OpenXML(string filename, object stylesheets)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, stylesheets);
			object returnItem = Invoker.MethodReturn(this, "OpenXML", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Stylesheets">optional object Stylesheets</param>
		/// <param name="LoadOption">optional object LoadOption</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Workbook OpenXML(string filename, object stylesheets, object loadOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, stylesheets, loadOption);
			object returnItem = Invoker.MethodReturn(this, "OpenXML", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Workbook OpenXML(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "OpenXML", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Stylesheets">optional object Stylesheets</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Workbook _OpenXML(string filename, object stylesheets)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, stylesheets);
			object returnItem = Invoker.MethodReturn(this, "_OpenXML", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Filename">string Filename</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Workbook _OpenXML(string filename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename);
			object returnItem = Invoker.MethodReturn(this, "_OpenXML", paramsArray);
			NetOffice.ExcelApi.Workbook newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Workbook.LateBindingApiWrapperType) as NetOffice.ExcelApi.Workbook;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Excel", 9,10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
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