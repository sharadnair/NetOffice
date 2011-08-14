//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IDialog SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IDialog : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IDialog);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDialog()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Arg1">optional object Arg1</param>
		/// <param name="Arg2">optional object Arg2</param>
		/// <param name="Arg3">optional object Arg3</param>
		/// <param name="Arg4">optional object Arg4</param>
		/// <param name="Arg5">optional object Arg5</param>
		/// <param name="Arg6">optional object Arg6</param>
		/// <param name="Arg7">optional object Arg7</param>
		/// <param name="Arg8">optional object Arg8</param>
		/// <param name="Arg9">optional object Arg9</param>
		/// <param name="Arg10">optional object Arg10</param>
		/// <param name="Arg11">optional object Arg11</param>
		/// <param name="Arg12">optional object Arg12</param>
		/// <param name="Arg13">optional object Arg13</param>
		/// <param name="Arg14">optional object Arg14</param>
		/// <param name="Arg15">optional object Arg15</param>
		/// <param name="Arg16">optional object Arg16</param>
		/// <param name="Arg17">optional object Arg17</param>
		/// <param name="Arg18">optional object Arg18</param>
		/// <param name="Arg19">optional object Arg19</param>
		/// <param name="Arg20">optional object Arg20</param>
		/// <param name="Arg21">optional object Arg21</param>
		/// <param name="Arg22">optional object Arg22</param>
		/// <param name="Arg23">optional object Arg23</param>
		/// <param name="Arg24">optional object Arg24</param>
		/// <param name="Arg25">optional object Arg25</param>
		/// <param name="Arg26">optional object Arg26</param>
		/// <param name="Arg27">optional object Arg27</param>
		/// <param name="Arg28">optional object Arg28</param>
		/// <param name="Arg29">optional object Arg29</param>
		/// <param name="Arg30">optional object Arg30</param>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Show(object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15, object arg16, object arg17, object arg18, object arg19, object arg20, object arg21, object arg22, object arg23, object arg24, object arg25, object arg26, object arg27, object arg28, object arg29, object arg30)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 9,10,11,12,14)]
		public bool Show()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Show", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}