//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// Interface IEnumPrivacyRecords SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IEnumPrivacyRecords : COMObject
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
                    _type = typeof(IEnumPrivacyRecords);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumPrivacyRecords(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumPrivacyRecords(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumPrivacyRecords(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumPrivacyRecords() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumPrivacyRecords(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 reset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "reset", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pSize">Int32 pSize</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 GetSize(Int32 pSize)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pSize);
			object returnItem = Invoker.MethodReturn(this, "GetSize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pState">Int32 pState</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 GetPrivacyImpacted(Int32 pState)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pState);
			object returnItem = Invoker.MethodReturn(this, "GetPrivacyImpacted", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pbstrUrl">string pbstrUrl</param>
		/// <param name="pbstrPolicyRef">string pbstrPolicyRef</param>
		/// <param name="pdwReserved">Int32 pdwReserved</param>
		/// <param name="pdwPrivacyFlags">Int32 pdwPrivacyFlags</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 Next(string pbstrUrl, string pbstrPolicyRef, Int32 pdwReserved, Int32 pdwPrivacyFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pbstrUrl, pbstrPolicyRef, pdwReserved, pdwPrivacyFlags);
			object returnItem = Invoker.MethodReturn(this, "Next", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}