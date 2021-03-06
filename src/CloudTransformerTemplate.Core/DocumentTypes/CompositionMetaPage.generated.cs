//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.6
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace CloudTransformerTemplate.Core.DocumentTypes
{
	// Mixin Content Type with alias "compositionMetaPage"
	/// <summary>Composition Meta Page</summary>
	public partial interface ICompositionMetaPage : IPublishedContent
	{
		/// <summary>Meta Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string MetaDescription { get; }

		/// <summary>Meta Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string MetaKeywords { get; }

		/// <summary>Meta Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string MetaTitle { get; }

		/// <summary>Robots No Follow</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		bool RobotsNoFollow { get; }

		/// <summary>Robots No Index</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		bool RobotsNoIndex { get; }
	}

	/// <summary>Composition Meta Page</summary>
	[PublishedModel("compositionMetaPage")]
	public partial class CompositionMetaPage : PublishedContentModel, ICompositionMetaPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "compositionMetaPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompositionMetaPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CompositionMetaPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Meta Description: The meta description to be used for the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => GetMetaDescription(this);

		/// <summary>Static getter for Meta Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetMetaDescription(ICompositionMetaPage that) => that.Value<string>("metaDescription");

		///<summary>
		/// Meta Keywords: The meta keywords to be used for the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords => GetMetaKeywords(this);

		/// <summary>Static getter for Meta Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetMetaKeywords(ICompositionMetaPage that) => that.Value<string>("metaKeywords");

		///<summary>
		/// Meta Title: The title to be used for the current page, in conjunction with the site title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle => GetMetaTitle(this);

		/// <summary>Static getter for Meta Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetMetaTitle(ICompositionMetaPage that) => that.Value<string>("metaTitle");

		///<summary>
		/// Robots No Follow: When selected, search engines will be told not to follow links on the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("robotsNoFollow")]
		public bool RobotsNoFollow => GetRobotsNoFollow(this);

		/// <summary>Static getter for Robots No Follow</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static bool GetRobotsNoFollow(ICompositionMetaPage that) => that.Value<bool>("robotsNoFollow");

		///<summary>
		/// Robots No Index: When selected, search engines will be told not to index the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("robotsNoIndex")]
		public bool RobotsNoIndex => GetRobotsNoIndex(this);

		/// <summary>Static getter for Robots No Index</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static bool GetRobotsNoIndex(ICompositionMetaPage that) => that.Value<bool>("robotsNoIndex");
	}
}
