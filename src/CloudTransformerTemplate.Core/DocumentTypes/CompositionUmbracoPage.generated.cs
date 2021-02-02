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
	// Mixin Content Type with alias "compositionUmbracoPage"
	/// <summary>Composition Umbraco Page</summary>
	public partial interface ICompositionUmbracoPage : IPublishedContent
	{
		/// <summary>Umbraco Internal Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent UmbracoInternalRedirect { get; }

		/// <summary>Umbraco Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		IPublishedContent UmbracoRedirect { get; }

		/// <summary>Umbraco Url Alias</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string UmbracoUrlAlias { get; }

		/// <summary>Umbraco Url Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		string UmbracoUrlName { get; }
	}

	/// <summary>Composition Umbraco Page</summary>
	[PublishedModel("compositionUmbracoPage")]
	public partial class CompositionUmbracoPage : PublishedContentModel, ICompositionUmbracoPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "compositionUmbracoPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompositionUmbracoPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CompositionUmbracoPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Umbraco Internal Redirect: Umbraco will load the selected page’s content transparently without performing any URL redirection. This essentially performs a rewrite.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoInternalRedirect")]
		public IPublishedContent UmbracoInternalRedirect => GetUmbracoInternalRedirect(this);

		/// <summary>Static getter for Umbraco Internal Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetUmbracoInternalRedirect(ICompositionUmbracoPage that) => that.Value<IPublishedContent>("umbracoInternalRedirect");

		///<summary>
		/// Umbraco Redirect: Lets you create a 302 temporary redirect. This in effect means that when a user navigates to this node, they will be redirected away.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => GetUmbracoRedirect(this);

		/// <summary>Static getter for Umbraco Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedContent GetUmbracoRedirect(ICompositionUmbracoPage that) => that.Value<IPublishedContent>("umbracoRedirect");

		///<summary>
		/// Umbraco Url Alias: A comma separated list of alternate full URL paths for the node. For example, if your URL was /some-category/some-page/content-node, by adding an alias of "flowers", a user can navigate to the node by simply going to /flowers.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => GetUmbracoUrlAlias(this);

		/// <summary>Static getter for Umbraco Url Alias</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetUmbracoUrlAlias(ICompositionUmbracoPage that) => that.Value<string>("umbracoUrlAlias");

		///<summary>
		/// Umbraco Url Name: If you enter a value for this property and save/publish the content node you will see that it's main URL is updated with a new path suffix.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => GetUmbracoUrlName(this);

		/// <summary>Static getter for Umbraco Url Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static string GetUmbracoUrlName(ICompositionUmbracoPage that) => that.Value<string>("umbracoUrlName");
	}
}