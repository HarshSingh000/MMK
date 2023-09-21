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

[assembly: RegisterDocumentType(ContactDeails.CLASS_NAME, typeof(ContactDeails))]

namespace CMS.DocumentEngine.Types.MMK
{
	/// <summary>
	/// Represents a content item of type ContactDeails.
	/// </summary>
	public partial class ContactDeails : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MMK.ContactDeails";


		/// <summary>
		/// The instance of the class that provides extended API for working with ContactDeails fields.
		/// </summary>
		private readonly ContactDeailsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactDeailsID.
		/// </summary>
		[DatabaseIDField]
		public int ContactDeailsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactDeailsID"), 0);
			}
			set
			{
				SetValue("ContactDeailsID", value);
			}
		}


		/// <summary>
		/// Location.
		/// </summary>
		[DatabaseField]
		public string Location
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Location"), @"");
			}
			set
			{
				SetValue("Location", value);
			}
		}


		/// <summary>
		/// Email.
		/// </summary>
		[DatabaseField]
		public string Email
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Email"), @"");
			}
			set
			{
				SetValue("Email", value);
			}
		}


		/// <summary>
		/// Call.
		/// </summary>
		[DatabaseField]
		public long Call
		{
			get
			{
				return ValidationHelper.GetLong(GetValue("Call"), 0);
			}
			set
			{
				SetValue("Call", value);
			}
		}


		/// <summary>
		/// Google Map Link.
		/// </summary>
		[DatabaseField]
		public string Google_Map_Link
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Google_Map_Link"), @"");
			}
			set
			{
				SetValue("Google_Map_Link", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ContactDeails fields.
		/// </summary>
		[RegisterProperty]
		public ContactDeailsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ContactDeails fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactDeailsFields : AbstractHierarchicalObject<ContactDeailsFields>
		{
			/// <summary>
			/// The content item of type ContactDeails that is a target of the extended API.
			/// </summary>
			private readonly ContactDeails mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactDeailsFields" /> class with the specified content item of type ContactDeails.
			/// </summary>
			/// <param name="instance">The content item of type ContactDeails that is a target of the extended API.</param>
			public ContactDeailsFields(ContactDeails instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactDeailsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactDeailsID;
				}
				set
				{
					mInstance.ContactDeailsID = value;
				}
			}


			/// <summary>
			/// Location.
			/// </summary>
			public string Location
			{
				get
				{
					return mInstance.Location;
				}
				set
				{
					mInstance.Location = value;
				}
			}


			/// <summary>
			/// Email.
			/// </summary>
			public string Email
			{
				get
				{
					return mInstance.Email;
				}
				set
				{
					mInstance.Email = value;
				}
			}


			/// <summary>
			/// Call.
			/// </summary>
			public long Call
			{
				get
				{
					return mInstance.Call;
				}
				set
				{
					mInstance.Call = value;
				}
			}


			/// <summary>
			/// Google Map Link.
			/// </summary>
			public string Google_Map_Link
			{
				get
				{
					return mInstance.Google_Map_Link;
				}
				set
				{
					mInstance.Google_Map_Link = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactDeails" /> class.
		/// </summary>
		public ContactDeails() : base(CLASS_NAME)
		{
			mFields = new ContactDeailsFields(this);
		}

		#endregion
	}
}