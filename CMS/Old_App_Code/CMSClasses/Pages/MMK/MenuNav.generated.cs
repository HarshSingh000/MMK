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

[assembly: RegisterDocumentType(MenuNav.CLASS_NAME, typeof(MenuNav))]

namespace CMS.DocumentEngine.Types.MMK
{
	/// <summary>
	/// Represents a content item of type MenuNav.
	/// </summary>
	public partial class MenuNav : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MMK.MenuNav";


		/// <summary>
		/// The instance of the class that provides extended API for working with MenuNav fields.
		/// </summary>
		private readonly MenuNavFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeID.
		/// </summary>
		[DatabaseIDField]
		public int HomeID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeID"), 0);
			}
			set
			{
				SetValue("HomeID", value);
			}
		}


		/// <summary>
		/// Menu Name.
		/// </summary>
		[DatabaseField]
		public string MenuName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MenuName"), @"");
			}
			set
			{
				SetValue("MenuName", value);
			}
		}


		/// <summary>
		/// Link.
		/// </summary>
		[DatabaseField]
		public string Link
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Link"), @"");
			}
			set
			{
				SetValue("Link", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MenuNav fields.
		/// </summary>
		[RegisterProperty]
		public MenuNavFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MenuNav fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MenuNavFields : AbstractHierarchicalObject<MenuNavFields>
		{
			/// <summary>
			/// The content item of type MenuNav that is a target of the extended API.
			/// </summary>
			private readonly MenuNav mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MenuNavFields" /> class with the specified content item of type MenuNav.
			/// </summary>
			/// <param name="instance">The content item of type MenuNav that is a target of the extended API.</param>
			public MenuNavFields(MenuNav instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeID.
			/// </summary>
			public int HomeID
			{
				get
				{
					return mInstance.HomeID;
				}
				set
				{
					mInstance.HomeID = value;
				}
			}


			/// <summary>
			/// Menu Name.
			/// </summary>
			public string MenuName
			{
				get
				{
					return mInstance.MenuName;
				}
				set
				{
					mInstance.MenuName = value;
				}
			}


			/// <summary>
			/// Link.
			/// </summary>
			public string Link
			{
				get
				{
					return mInstance.Link;
				}
				set
				{
					mInstance.Link = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MenuNav" /> class.
		/// </summary>
		public MenuNav() : base(CLASS_NAME)
		{
			mFields = new MenuNavFields(this);
		}

		#endregion
	}
}