//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MMK;

[assembly: RegisterDocumentType(Dropdown.CLASS_NAME, typeof(Dropdown))]

namespace CMS.DocumentEngine.Types.MMK
{
	/// <summary>
	/// Represents a content item of type Dropdown.
	/// </summary>
	public partial class Dropdown : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MMK.Dropdown";


		/// <summary>
		/// The instance of the class that provides extended API for working with Dropdown fields.
		/// </summary>
		private readonly DropdownFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// DropdownID.
		/// </summary>
		[DatabaseIDField]
		public int DropdownID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("DropdownID"), 0);
			}
			set
			{
				SetValue("DropdownID", value);
			}
		}


		/// <summary>
		/// EmployeeName.
		/// </summary>
		[DatabaseField]
		public string EmployeeName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EmployeeName"), @"");
			}
			set
			{
				SetValue("EmployeeName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Dropdown fields.
		/// </summary>
		[RegisterProperty]
		public DropdownFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Dropdown fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class DropdownFields : AbstractHierarchicalObject<DropdownFields>
		{
			/// <summary>
			/// The content item of type Dropdown that is a target of the extended API.
			/// </summary>
			private readonly Dropdown mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="DropdownFields" /> class with the specified content item of type Dropdown.
			/// </summary>
			/// <param name="instance">The content item of type Dropdown that is a target of the extended API.</param>
			public DropdownFields(Dropdown instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// DropdownID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.DropdownID;
				}
				set
				{
					mInstance.DropdownID = value;
				}
			}


			/// <summary>
			/// EmployeeName.
			/// </summary>
			public string EmployeeName
			{
				get
				{
					return mInstance.EmployeeName;
				}
				set
				{
					mInstance.EmployeeName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Dropdown" /> class.
		/// </summary>
		public Dropdown() : base(CLASS_NAME)
		{
			mFields = new DropdownFields(this);
		}

		#endregion
	}
}