﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSProjectApi
{
	/// <summary>
	/// DispatchInterface GroupCriterion2 
	/// SupportByVersion MSProject, 11,14
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff920614(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,14)]
	[EntityType(EntityType.IsDispatchInterface)]
	[TypeId("11589057-69F0-11D2-B889-00C04FB90729")]
	public interface GroupCriterion2 : ICOMObject
	{
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		string FieldName { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		Int32 Index { get; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Group2 Parent { get; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		bool Ascending { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		string FontName { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		Int32 FontSize { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		bool FontBold { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		bool FontItalic { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		bool FontUnderLine { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Enums.PjColor FontColor { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Enums.PjColor CellColor { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Enums.PjBackgroundPattern Pattern { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		NetOffice.MSProjectApi.Enums.PjGroupOn GroupOn { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		object StartAt { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		object GroupInterval { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		bool Assignment { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		Int32 FontColorEx { get; set; }

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		Int32 CellColorEx { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSProject 11, 14
		/// </summary>
		[SupportByVersion("MSProject", 11,14)]
		void Delete();

		#endregion
	}
}
