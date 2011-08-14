//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface _CodeModule SupportByLibrary VBIDE, 5.3,12
	///</summary>
	[SupportByLibrary("VBIDE", 5.3,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _CodeModule : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_CodeModule);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CodeModule(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CodeModule(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CodeModule(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CodeModule()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBComponent Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.VBIDEApi.VBComponent newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.VBComponent;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.VBE VBE
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VBE", paramsArray);
				NetOffice.VBIDEApi.VBE newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.VBE;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
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
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="StartLine">Int32 StartLine</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public string get_Lines(Int32 startLine, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(startLine, count);
			object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 CountOfLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfLines", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 get_ProcStartLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcStartLine", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 get_ProcCountLines(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcCountLines", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 get_ProcBodyLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcBodyLine", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public string get_ProcOfLine(Int32 line, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcOfLine", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 CountOfDeclarationLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfDeclarationLines", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public NetOffice.VBIDEApi.CodePane CodePane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CodePane", paramsArray);
				NetOffice.VBIDEApi.CodePane newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.CodePane;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="String">string String</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void AddFromString(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			Invoker.Method(this, "AddFromString", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void AddFromFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "AddFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="String">string String</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void InsertLines(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "InsertLines", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="StartLine">Int32 StartLine</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void DeleteLines(Int32 startLine, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(startLine, count);
			Invoker.Method(this, "DeleteLines", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="String">string String</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public void ReplaceLine(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "ReplaceLine", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="EventName">string EventName</param>
		/// <param name="ObjectName">string ObjectName</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public Int32 CreateEventProc(string eventName, string objectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eventName, objectName);
			object returnItem = Invoker.MethodReturn(this, "CreateEventProc", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary VBIDE 5.3, 12
		/// </summary>
		/// <param name="Target">string Target</param>
		/// <param name="StartLine">Int32 StartLine</param>
		/// <param name="StartColumn">Int32 StartColumn</param>
		/// <param name="EndLine">Int32 EndLine</param>
		/// <param name="EndColumn">Int32 EndColumn</param>
		/// <param name="WholeWord">bool WholeWord</param>
		/// <param name="MatchCase">bool MatchCase</param>
		/// <param name="PatternSearch">bool PatternSearch</param>
		[SupportByLibrary("VBIDE", 5.3,12)]
		public bool Find(string target, Int32 startLine, Int32 startColumn, Int32 endLine, Int32 endColumn, bool wholeWord, bool matchCase, bool patternSearch)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn, wholeWord, matchCase, patternSearch);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}