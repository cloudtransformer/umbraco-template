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
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, ICompositionMetaPage, ICompositionSitemapPage, ICompositionUmbracoPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Meta Description: The meta description to be used for the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => CompositionMetaPage.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: The meta keywords to be used for the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords => CompositionMetaPage.GetMetaKeywords(this);

		///<summary>
		/// Meta Title: The title to be used for the current page, in conjunction with the site title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle => CompositionMetaPage.GetMetaTitle(this);

		///<summary>
		/// Robots No Follow: When selected, search engines will be told not to follow links on the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("robotsNoFollow")]
		public bool RobotsNoFollow => CompositionMetaPage.GetRobotsNoFollow(this);

		///<summary>
		/// Robots No Index: When selected, search engines will be told not to index the current page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("robotsNoIndex")]
		public bool RobotsNoIndex => CompositionMetaPage.GetRobotsNoIndex(this);

		///<summary>
		/// Sitemap Change Frequency: Suggestion to search engines with regards to how often the content of the page will.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sitemapChangeFrequency")]
		public string SitemapChangeFrequency => CompositionSitemapPage.GetSitemapChangeFrequency(this);

		///<summary>
		/// Sitemap Priority: The priority of this page relative to other pages on your.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("sitemapPriority")]
		public decimal SitemapPriority => CompositionSitemapPage.GetSitemapPriority(this);

		///<summary>
		/// Umbraco Internal Redirect: Umbraco will load the selected page’s content transparently without performing any URL redirection. This essentially performs a rewrite.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoInternalRedirect")]
		public IPublishedContent UmbracoInternalRedirect => CompositionUmbracoPage.GetUmbracoInternalRedirect(this);

		///<summary>
		/// Umbraco Redirect: Lets you create a 302 temporary redirect. This in effect means that when a user navigates to this node, they will be redirected away.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => CompositionUmbracoPage.GetUmbracoRedirect(this);

		///<summary>
		/// Umbraco Url Alias: A comma separated list of alternate full URL paths for the node. For example, if your URL was /some-category/some-page/content-node, by adding an alias of "flowers", a user can navigate to the node by simply going to /flowers.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => CompositionUmbracoPage.GetUmbracoUrlAlias(this);

		///<summary>
		/// Umbraco Url Name: If you enter a value for this property and save/publish the content node you will see that it's main URL is updated with a new path suffix.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.6")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => CompositionUmbracoPage.GetUmbracoUrlName(this);
	}
}
