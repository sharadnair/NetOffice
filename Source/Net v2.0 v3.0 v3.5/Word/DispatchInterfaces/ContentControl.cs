//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ContentControl SupportByLibrary Word, 12,14
	///</summary>
	[SupportByLibrary("Word", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ContentControl : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ContentControl);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ContentControl()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
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
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool LockContentControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockContentControl", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockContentControl", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool LockContents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockContents", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockContents", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.XMLMapping XMLMapping
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XMLMapping", paramsArray);
				NetOffice.WordApi.XMLMapping newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.XMLMapping;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdContentControlType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.WordApi.Enums.WdContentControlType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.ContentControlListEntries DropdownListEntries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropdownListEntries", paramsArray);
				NetOffice.WordApi.ContentControlListEntries newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ContentControlListEntries;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.BuildingBlock PlaceholderText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlaceholderText", paramsArray);
				NetOffice.WordApi.BuildingBlock newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.BuildingBlock;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string DateDisplayFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateDisplayFormat", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateDisplayFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool MultiLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MultiLine", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MultiLine", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.ContentControl ParentContentControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentContentControl", paramsArray);
				NetOffice.WordApi.ContentControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ContentControl;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool Temporary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Temporary", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Temporary", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ShowingPlaceholderText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowingPlaceholderText", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdContentControlDateStorageFormat DateStorageFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateStorageFormat", paramsArray);
				return (NetOffice.WordApi.Enums.WdContentControlDateStorageFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateStorageFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdBuildingBlockTypes BuildingBlockType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuildingBlockType", paramsArray);
				return (NetOffice.WordApi.Enums.WdBuildingBlockTypes)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BuildingBlockType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string BuildingBlockCategory
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuildingBlockCategory", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BuildingBlockCategory", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID DateDisplayLocale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateDisplayLocale", paramsArray);
				return (NetOffice.WordApi.Enums.WdLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateDisplayLocale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public object DefaultTextStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultTextStyle", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultTextStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdCalendarType DateCalendarType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateCalendarType", paramsArray);
				return (NetOffice.WordApi.Enums.WdCalendarType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateCalendarType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string Tag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tag", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Tag", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool Checked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Checked", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Checked", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="DeleteContents">bool DeleteContents</param>
		[SupportByLibrary("Word", 12,14)]
		public void Delete(bool deleteContents)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(deleteContents);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		/// <param name="BuildingBlock">NetOffice.WordApi.BuildingBlock BuildingBlock</param>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Text">string Text</param>
		[SupportByLibrary("Word", 12,14)]
		public void SetPlaceholderText(NetOffice.WordApi.BuildingBlock buildingBlock, NetOffice.WordApi.Range range, string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(buildingBlock, range, text);
			Invoker.Method(this, "SetPlaceholderText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public void Ungroup()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Ungroup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="CharacterNumber">Int32 CharacterNumber</param>
		/// <param name="Font">string Font</param>
		[SupportByLibrary("Word", 14)]
		public void SetCheckedSymbol(Int32 characterNumber, string font)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(characterNumber, font);
			Invoker.Method(this, "SetCheckedSymbol", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="CharacterNumber">Int32 CharacterNumber</param>
		/// <param name="Font">string Font</param>
		[SupportByLibrary("Word", 14)]
		public void SetUncheckedSymbol(Int32 characterNumber, string font)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(characterNumber, font);
			Invoker.Method(this, "SetUncheckedSymbol", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}