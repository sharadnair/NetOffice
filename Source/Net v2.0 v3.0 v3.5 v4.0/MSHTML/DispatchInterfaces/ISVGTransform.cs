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
	/// DispatchInterface ISVGTransform SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ISVGTransform : COMObject
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
                    _type = typeof(ISVGTransform);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransform(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransform(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransform(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransform() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISVGTransform(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int16 type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "type", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGMatrix matrix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "matrix", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGMatrix newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGMatrix;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "matrix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Single angle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "angle", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "angle", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="matrix">LateBindingApi.MSHTMLApi.ISVGMatrix matrix</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setMatrix(LateBindingApi.MSHTMLApi.ISVGMatrix matrix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(matrix);
			Invoker.Method(this, "setMatrix", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="tx">Single tx</param>
		/// <param name="ty">Single ty</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setTranslate(Single tx, Single ty)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tx, ty);
			Invoker.Method(this, "setTranslate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="sx">Single sx</param>
		/// <param name="sy">Single sy</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setScale(Single sx, Single sy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sx, sy);
			Invoker.Method(this, "setScale", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="angle">Single angle</param>
		/// <param name="cx">Single cx</param>
		/// <param name="cy">Single cy</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setRotate(Single angle, Single cx, Single cy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(angle, cx, cy);
			Invoker.Method(this, "setRotate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="angle">Single angle</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setSkewX(Single angle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(angle);
			Invoker.Method(this, "setSkewX", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="angle">Single angle</param>
		[SupportByLibrary("MSHTML", 4)]
		public void setSkewY(Single angle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(angle);
			Invoker.Method(this, "setSkewY", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}