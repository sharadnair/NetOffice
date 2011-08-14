//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface IEnumOleUndoUnits SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IEnumOleUndoUnits : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IEnumOleUndoUnits);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumOleUndoUnits()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="rgElt">NetOffice.OWC10Api.IOleUndoUnit rgElt</param>
		/// <param name="pcEltFetched">Int32 pcEltFetched</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 RemoteNext(Int32 cElt, NetOffice.OWC10Api.IOleUndoUnit rgElt, Int32 pcEltFetched)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, rgElt, pcEltFetched);
			object returnItem = Invoker.MethodReturn(this, "RemoteNext", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Skip(Int32 cElt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cElt);
			object returnItem = Invoker.MethodReturn(this, "Skip", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Reset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reset", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="ppEnum">NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 Clone(NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}