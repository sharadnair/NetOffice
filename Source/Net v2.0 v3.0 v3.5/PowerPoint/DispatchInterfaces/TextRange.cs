//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface TextRange SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TextRange : Collection
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TextRange);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextRange()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ActionSettings ActionSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActionSettings", paramsArray);
				NetOffice.PowerPointApi.ActionSettings newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ActionSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 Start
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Start", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 Length
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Length", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single BoundLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundLeft", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single BoundTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundTop", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single BoundWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundWidth", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single BoundHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BoundHeight", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.PowerPointApi.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Font;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ParagraphFormat ParagraphFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParagraphFormat", paramsArray);
				NetOffice.PowerPointApi.ParagraphFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ParagraphFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 IndentLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IndentLevel", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IndentLevel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoLanguageID LanguageID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageID", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Paragraphs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Paragraphs", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Sentences(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Sentences", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Words(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Words", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Characters(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Characters", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Lines(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Lines", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Start">Int32 Start</param>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Runs(Int32 start, Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start, length);
			object returnItem = Invoker.MethodReturn(this, "Runs", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange TrimText()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "TrimText", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NewText">string NewText</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange InsertAfter(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertAfter", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NewText">string NewText</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange InsertBefore(string newText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newText);
			object returnItem = Invoker.MethodReturn(this, "InsertBefore", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="DateTimeFormat">NetOffice.PowerPointApi.Enums.PpDateTimeFormat DateTimeFormat</param>
		/// <param name="InsertAsField">NetOffice.OfficeApi.Enums.MsoTriState InsertAsField</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange InsertDateTime(NetOffice.PowerPointApi.Enums.PpDateTimeFormat dateTimeFormat, NetOffice.OfficeApi.Enums.MsoTriState insertAsField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dateTimeFormat, insertAsField);
			object returnItem = Invoker.MethodReturn(this, "InsertDateTime", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange InsertSlideNumber()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "InsertSlideNumber", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FontName">string FontName</param>
		/// <param name="CharNumber">Int32 CharNumber</param>
		/// <param name="Unicode">NetOffice.OfficeApi.Enums.MsoTriState Unicode</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange InsertSymbol(string fontName, Int32 charNumber, NetOffice.OfficeApi.Enums.MsoTriState unicode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fontName, charNumber, unicode);
			object returnItem = Invoker.MethodReturn(this, "InsertSymbol", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.PpChangeCase Type</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void ChangeCase(NetOffice.PowerPointApi.Enums.PpChangeCase type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "ChangeCase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void AddPeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddPeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void RemovePeriods()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemovePeriods", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FindWhat">string FindWhat</param>
		/// <param name="After">Int32 After</param>
		/// <param name="MatchCase">NetOffice.OfficeApi.Enums.MsoTriState MatchCase</param>
		/// <param name="WholeWords">NetOffice.OfficeApi.Enums.MsoTriState WholeWords</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Find(string findWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase, NetOffice.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FindWhat">string FindWhat</param>
		/// <param name="ReplaceWhat">string ReplaceWhat</param>
		/// <param name="After">Int32 After</param>
		/// <param name="MatchCase">NetOffice.OfficeApi.Enums.MsoTriState MatchCase</param>
		/// <param name="WholeWords">NetOffice.OfficeApi.Enums.MsoTriState WholeWords</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange Replace(string findWhat, string replaceWhat, Int32 after, NetOffice.OfficeApi.Enums.MsoTriState matchCase, NetOffice.OfficeApi.Enums.MsoTriState wholeWords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(findWhat, replaceWhat, after, matchCase, wholeWords);
			object returnItem = Invoker.MethodReturn(this, "Replace", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">Single X2</param>
		/// <param name="Y2">Single Y2</param>
		/// <param name="X3">Single X3</param>
		/// <param name="Y3">Single Y3</param>
		/// <param name="x4">Single x4</param>
		/// <param name="y4">Single y4</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void RotatedBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x1, y1, x2, y2, x3, y3, x4, y4);
			Invoker.Method(this, "RotatedBounds", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void RtlRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RtlRun", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void LtrRun()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LtrRun", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="DataType">NetOffice.PowerPointApi.Enums.PpPasteDataType DataType</param>
		/// <param name="DisplayAsIcon">NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon</param>
		/// <param name="IconFileName">string IconFileName</param>
		/// <param name="IconIndex">Int32 IconIndex</param>
		/// <param name="IconLabel">string IconLabel</param>
		/// <param name="Link">NetOffice.OfficeApi.Enums.MsoTriState Link</param>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.TextRange PasteSpecial(NetOffice.PowerPointApi.Enums.PpPasteDataType dataType, NetOffice.OfficeApi.Enums.MsoTriState displayAsIcon, string iconFileName, Int32 iconIndex, string iconLabel, NetOffice.OfficeApi.Enums.MsoTriState link)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName, iconIndex, iconLabel, link);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.TextRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TextRange;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}