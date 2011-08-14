//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _RuleActions SupportByLibrary Outlook, 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _RuleActions : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_RuleActions);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RuleActions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RuleActions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RuleActions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _RuleActions()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
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

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
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
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.MoveOrCopyRuleAction CopyToFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CopyToFolder", paramsArray);
				NetOffice.OutlookApi.MoveOrCopyRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MoveOrCopyRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction DeletePermanently
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DeletePermanently", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction Delete
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Delete", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction DesktopAlert
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DesktopAlert", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction NotifyDelivery
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NotifyDelivery", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction NotifyRead
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NotifyRead", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction Stop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stop", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.MoveOrCopyRuleAction MoveToFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MoveToFolder", paramsArray);
				NetOffice.OutlookApi.MoveOrCopyRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MoveOrCopyRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SendRuleAction CC
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CC", paramsArray);
				NetOffice.OutlookApi.SendRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.SendRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SendRuleAction Forward
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Forward", paramsArray);
				NetOffice.OutlookApi.SendRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.SendRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SendRuleAction ForwardAsAttachment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForwardAsAttachment", paramsArray);
				NetOffice.OutlookApi.SendRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.SendRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SendRuleAction Redirect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Redirect", paramsArray);
				NetOffice.OutlookApi.SendRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.SendRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.AssignToCategoryRuleAction AssignToCategory
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AssignToCategory", paramsArray);
				NetOffice.OutlookApi.AssignToCategoryRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.AssignToCategoryRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.PlaySoundRuleAction PlaySound
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlaySound", paramsArray);
				NetOffice.OutlookApi.PlaySoundRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.PlaySoundRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.MarkAsTaskRuleAction MarkAsTask
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkAsTask", paramsArray);
				NetOffice.OutlookApi.MarkAsTaskRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MarkAsTaskRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.NewItemAlertRuleAction NewItemAlert
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NewItemAlert", paramsArray);
				NetOffice.OutlookApi.NewItemAlertRuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.NewItemAlertRuleAction;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.RuleAction ClearCategories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ClearCategories", paramsArray);
				NetOffice.OutlookApi.RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.RuleAction;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi._RuleAction this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi._RuleAction newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._RuleAction;
				return newObject;
			}
		}

		#endregion
		#pragma warning restore
	}
}