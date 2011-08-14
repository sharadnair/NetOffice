//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPStrings SupportByLibrary PowerPoint, 9
	///</summary>
	[SupportByLibrary("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPStrings : Collection
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PPStrings);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPStrings(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPStrings(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPStrings(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPStrings()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("PowerPoint", 9)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public string this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="String">string String</param>
		[SupportByLibrary("PowerPoint", 9)]
		public string Add(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="String">string String</param>
		/// <param name="Position">Int32 Position</param>
		[SupportByLibrary("PowerPoint", 9)]
		public void Insert(string _string, Int32 position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string, position);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("PowerPoint", 9)]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}