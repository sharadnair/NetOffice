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
	/// DispatchInterface HTMLElementEvents4 SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class HTMLElementEvents4 : COMObject
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
                    _type = typeof(HTMLElementEvents4);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLElementEvents4(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLElementEvents4(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLElementEvents4(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLElementEvents4() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLElementEvents4(string progId) : base(progId)
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
		public void onabort(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onabort", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onchange(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onchange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onerror(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onerror", paramsArray);
		}

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
		public void onreset(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onreset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onselect(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onselect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibrary("MSHTML", 4)]
		public void onsubmit(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onsubmit", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}