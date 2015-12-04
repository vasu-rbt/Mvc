//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Article.CLASS_NAME, typeof(Article))]

namespace CMS.DocumentEngine.Types
{
	/// <summary>
	/// Represents a content item of type Article.
	/// </summary>
	public partial class Article : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DancingGoatMvc.Article";


		/// <summary>
		/// The instance of the class that provides extended API for working with Article fields.
		/// </summary>
		private readonly ArticleFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ArticleID.
		/// </summary>
		[DatabaseIDField]
		public int ArticleID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ArticleID"), 0);
			}
			set
			{
				SetValue("ArticleID", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string ArticleTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ArticleTitle"), "");
			}
			set
			{
				SetValue("ArticleTitle", value);
			}
		}


		/// <summary>
		/// Teaser.
		/// </summary>
		[DatabaseField]
		public Guid ArticleTeaser
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ArticleTeaser"), Guid.Empty);
			}
			set
			{
				SetValue("ArticleTeaser", value);
			}
		}


		/// <summary>
		/// Summary.
		/// </summary>
		[DatabaseField]
		public string ArticleSummary
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ArticleSummary"), "");
			}
			set
			{
				SetValue("ArticleSummary", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string ArticleText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ArticleText"), "");
			}
			set
			{
				SetValue("ArticleText", value);
			}
		}


		/// <summary>
		/// Images.
		/// </summary>
		[DatabaseField]
		public string ArticleImages
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ArticleImages"), "");
			}
			set
			{
				SetValue("ArticleImages", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Article fields.
		/// </summary>
		public ArticleFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Article fields.
		/// </summary>
		public partial class ArticleFields
		{
			/// <summary>
			/// The content item of type Article that is a target of the extended API.
			/// </summary>
			private readonly Article mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CMS.DocumentEngine.Types.Article+ArticleFields" /> class with the specified content item of type Article.
			/// </summary>
			/// <param name="instance">The content item of type Article that is a target of the extended API.</param>
			public ArticleFields(Article instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ArticleID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ArticleID;
				}
				set
				{
					mInstance.ArticleID = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.ArticleTitle;
				}
				set
				{
					mInstance.ArticleTitle = value;
				}
			}


			/// <summary>
			/// Teaser.
			/// </summary>
			public Attachment Teaser
			{
				get
				{
					return mInstance.GetFieldAttachment("ArticleTeaser");
				}
			}


			/// <summary>
			/// Summary.
			/// </summary>
			public string Summary
			{
				get
				{
					return mInstance.ArticleSummary;
				}
				set
				{
					mInstance.ArticleSummary = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.ArticleText;
				}
				set
				{
					mInstance.ArticleText = value;
				}
			}


			/// <summary>
			/// Images.
			/// </summary>
			public IEnumerable<Attachment> Images
			{
				get
				{
					return mInstance.GetFieldAttachments("ArticleImages");
				}
			}


			/// <summary>
			/// Related articles.
			/// </summary>
			public IEnumerable<TreeNode> RelatedArticles
			{
				get
				{
					return mInstance.GetRelatedDocuments("ArticleRelatedArticles");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="CMS.DocumentEngine.Types.Article" /> class.
		/// </summary>
		public Article() : base(CLASS_NAME)
		{
			mFields = new ArticleFields(this);
		}

		#endregion
	}
}