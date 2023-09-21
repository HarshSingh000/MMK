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
using CMS.OnlineForms;
using CMS.OnlineForms.Types;

[assembly: RegisterBizForm(UserDetailsItem.CLASS_NAME, typeof(UserDetailsItem))]

namespace CMS.OnlineForms.Types
{
	/// <summary>
	/// Represents a content item of type UserDetailsItem.
	/// </summary>
	public partial class UserDetailsItem : BizFormItem
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "BizForm.UserDetails";


		/// <summary>
		/// The instance of the class that provides extended API for working with UserDetailsItem fields.
		/// </summary>
		private readonly UserDetailsItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// Name .
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Email.
		/// </summary>
		[DatabaseField]
		public string EmailInput
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EmailInput"), @"");
			}
			set
			{
				SetValue("EmailInput", value);
			}
		}


		/// <summary>
		/// Text input.
		/// </summary>
		[DatabaseField]
		public string TextInput
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TextInput"), @"");
			}
			set
			{
				SetValue("TextInput", value);
			}
		}


		/// <summary>
		/// Company's Employee.
		/// </summary>
		[DatabaseField]
		public bool Employee
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("Employee"), false);
			}
			set
			{
				SetValue("Employee", value);
			}
		}


		/// <summary>
		/// Message.
		/// </summary>
		[DatabaseField]
		public string Message
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Message"), @"");
			}
			set
			{
				SetValue("Message", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with UserDetailsItem fields.
		/// </summary>
		[RegisterProperty]
		public UserDetailsItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with UserDetailsItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class UserDetailsItemFields : AbstractHierarchicalObject<UserDetailsItemFields>
		{
			/// <summary>
			/// The content item of type UserDetailsItem that is a target of the extended API.
			/// </summary>
			private readonly UserDetailsItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="UserDetailsItemFields" /> class with the specified content item of type UserDetailsItem.
			/// </summary>
			/// <param name="instance">The content item of type UserDetailsItem that is a target of the extended API.</param>
			public UserDetailsItemFields(UserDetailsItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// Name .
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// Email.
			/// </summary>
			public string EmailInput
			{
				get
				{
					return mInstance.EmailInput;
				}
				set
				{
					mInstance.EmailInput = value;
				}
			}


			/// <summary>
			/// Text input.
			/// </summary>
			public string TextInput
			{
				get
				{
					return mInstance.TextInput;
				}
				set
				{
					mInstance.TextInput = value;
				}
			}


			/// <summary>
			/// Company's Employee.
			/// </summary>
			public bool Employee
			{
				get
				{
					return mInstance.Employee;
				}
				set
				{
					mInstance.Employee = value;
				}
			}


			/// <summary>
			/// Message.
			/// </summary>
			public string Message
			{
				get
				{
					return mInstance.Message;
				}
				set
				{
					mInstance.Message = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="UserDetailsItem" /> class.
		/// </summary>
		public UserDetailsItem() : base(CLASS_NAME)
		{
			mFields = new UserDetailsItemFields(this);
		}

		#endregion
	}
}