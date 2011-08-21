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
	/// DispatchInterface OverAllocatedAssignments SupportByLibrary MSProject, 14
	///</summary>
	[SupportByLibrary("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class OverAllocatedAssignments : COMObject ,IEnumerable
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
                    _type = typeof(OverAllocatedAssignments);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OverAllocatedAssignments(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OverAllocatedAssignments(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OverAllocatedAssignments(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OverAllocatedAssignments() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OverAllocatedAssignments(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("MSProject", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public LateBindingApi.MSProjectApi.Assignment this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.MSProjectApi.Assignment newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Assignment.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Assignment;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
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
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
		public Int32 TotalDetectedCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalDetectedCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
		public LateBindingApi.MSProjectApi.Task Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.MSProjectApi.Task newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Task.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Task;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 14
		/// Get
		/// </summary>
		[SupportByLibrary("MSProject", 14)]
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

		#endregion

		#region Methods

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("MSProject", 14)]
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