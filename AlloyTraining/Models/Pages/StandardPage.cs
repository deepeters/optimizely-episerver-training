using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GUID = "b0b7eee4-5e58-47ab-ad33-4673d39b48f0",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialised one.")]

    [SitePageIcon]
    [AvailableContentTypes(Include = new[] {typeof(StandardPage)},
        Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

    }
}