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

[assembly: RegisterDocumentType(Gallery.CLASS_NAME, typeof(Gallery))]

namespace CMS.DocumentEngine.Types.MMK
{
	/// <summary>
	/// Represents a content item of type Gallery.
	/// </summary>
	public partial class Gallery : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MMK.Gallery";


		/// <summary>
		/// The instance of the class that provides extended API for working with Gallery fields.
		/// </summary>
		private readonly GalleryFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// GalleryID.
		/// </summary>
		[DatabaseIDField]
		public int GalleryID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("GalleryID"), 0);
			}
			set
			{
				SetValue("GalleryID", value);
			}
		}


		/// <summary>
		/// Image Description.
		/// </summary>
		[DatabaseField]
		public string ImageDescription
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ImageDescription"), @"");
			}
			set
			{
				SetValue("ImageDescription", value);
			}
		}


		/// <summary>
		/// Image Title.
		/// </summary>
		[DatabaseField]
		public string ImageTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ImageTitle"), @"");
			}
			set
			{
				SetValue("ImageTitle", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Gallery fields.
		/// </summary>
		[RegisterProperty]
		public GalleryFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Gallery fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class GalleryFields : AbstractHierarchicalObject<GalleryFields>
		{
			/// <summary>
			/// The content item of type Gallery that is a target of the extended API.
			/// </summary>
			private readonly Gallery mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="GalleryFields" /> class with the specified content item of type Gallery.
			/// </summary>
			/// <param name="instance">The content item of type Gallery that is a target of the extended API.</param>
			public GalleryFields(Gallery instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// GalleryID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.GalleryID;
				}
				set
				{
					mInstance.GalleryID = value;
				}
			}


			/// <summary>
			/// Image Description.
			/// </summary>
			public string ImageDescription
			{
				get
				{
					return mInstance.ImageDescription;
				}
				set
				{
					mInstance.ImageDescription = value;
				}
			}


			/// <summary>
			/// Image Title.
			/// </summary>
			public string ImageTitle
			{
				get
				{
					return mInstance.ImageTitle;
				}
				set
				{
					mInstance.ImageTitle = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Gallery" /> class.
		/// </summary>
		public Gallery() : base(CLASS_NAME)
		{
			mFields = new GalleryFields(this);
		}

		#endregion
	}
}