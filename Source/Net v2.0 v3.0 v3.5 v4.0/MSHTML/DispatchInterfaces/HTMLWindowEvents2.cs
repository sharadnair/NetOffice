//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface HTMLWindowEvents2 SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class HTMLWindowEvents2 : COMObject
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
                    _type = typeof(HTMLWindowEvents2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLWindowEvents2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLWindowEvents2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLWindowEvents2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLWindowEvents2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLWindowEvents2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onload(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onload", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onunload(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onunload", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public bool onhelp(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onhelp", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onfocus(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onfocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onblur(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onblur", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="description">string description</param>
		/// <param name="url">string url</param>
		/// <param name="line">Int32 line</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onerror(string description, string url, Int32 line)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(description, url, line);
			Invoker.Method(this, "onerror", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onresize(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onresize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onscroll(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onscroll", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onbeforeunload(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onbeforeunload", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onbeforeprint(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onbeforeprint", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onafterprint(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onafterprint", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}