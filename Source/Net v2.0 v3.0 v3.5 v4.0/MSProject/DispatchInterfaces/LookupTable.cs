//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi
{
	///<summary>
	/// DispatchInterface LookupTable SupportByLibrary MSProject, 12,14
	///</summary>
	[SupportByLibrary("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class LookupTable : COMObject ,IEnumerable
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
                    _type = typeof(LookupTable);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LookupTable(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LookupTable(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LookupTable(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LookupTable() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LookupTable(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Application.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("MSProject", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public LateBindingApi.MSProjectApi.LookupTableEntry this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.MSProjectApi.LookupTableEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.LookupTableEntry.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.LookupTableEntry;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.OutlineCode Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.MSProjectApi.OutlineCode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.OutlineCode.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.OutlineCode;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="ParentUniqueID">optional object ParentUniqueID</param>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.LookupTableEntry AddChild(string name, object parentUniqueID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, parentUniqueID);
			object returnItem = Invoker.MethodReturn(this, "AddChild", paramsArray);
			LateBindingApi.MSProjectApi.LookupTableEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.LookupTableEntry.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.LookupTableEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.LookupTableEntry AddChild(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "AddChild", paramsArray);
			LateBindingApi.MSProjectApi.LookupTableEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.LookupTableEntry.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.LookupTableEntry;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("MSProject", 12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}