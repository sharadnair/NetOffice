﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.PowerPointApi;

namespace NetOffice.PowerPointApi.Behind
{
	/// <summary>
	/// DispatchInterface Marker 
	/// SupportByVersion PowerPoint, 9
	/// </summary>
	[SupportByVersion("PowerPoint", 9)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class Marker : COMObject, NetOffice.PowerPointApi.Marker
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.PowerPointApi.Marker);
                return _contractType;
            }
        }
        private static Type _contractType;


		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Marker);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Marker() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Enums.PpMarkerType MarkerType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.PowerPointApi.Enums.PpMarkerType>(this, "MarkerType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "MarkerType", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		public Int32 Time
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Time");
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}

