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
	/// DispatchInterface IHTMLCurrentStyle5 SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLCurrentStyle5 : COMObject
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
                    _type = typeof(IHTMLCurrentStyle5);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCurrentStyle5(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCurrentStyle5(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCurrentStyle5(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCurrentStyle5() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLCurrentStyle5(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string captionSide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "captionSide", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string outline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outline", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object outlineWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outlineWidth", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string outlineStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outlineStyle", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object outlineColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "outlineColor", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string boxSizing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "boxSizing", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string borderSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "borderSpacing", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object orphans
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "orphans", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object widows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "widows", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string pageBreakInside
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "pageBreakInside", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string emptyCells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "emptyCells", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string msBlockProgression
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "msBlockProgression", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string quotes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "quotes", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}