//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi
{
	///<summary>
	/// DispatchInterface ViewsSingle SupportByLibrary MSProject, 12,14
	///</summary>
	[SupportByLibrary("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ViewsSingle : Views
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
                    _type = typeof(ViewsSingle);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsSingle(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsSingle(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsSingle(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsSingle() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ViewsSingle(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Screen">LateBindingApi.MSProjectApi.Enums.PjViewScreen Screen</param>
		/// <param name="ShowInMenu">bool ShowInMenu</param>
		/// <param name="Table">object Table</param>
		/// <param name="Filter">object Filter</param>
		/// <param name="Group">object Group</param>
		/// <param name="HighlightFilt">bool HighlightFilt</param>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.ViewSingle Add(string name, LateBindingApi.MSProjectApi.Enums.PjViewScreen screen, bool showInMenu, object table, object filter, object group, bool highlightFilt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, screen, showInMenu, table, filter, group, highlightFilt);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.MSProjectApi.ViewSingle newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.ViewSingle.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.ViewSingle;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}