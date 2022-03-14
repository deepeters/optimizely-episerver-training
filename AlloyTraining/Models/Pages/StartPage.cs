using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage",
        GroupName = SiteGroupNames.Specialized, Order = 10,
        GUID = "cfb56fe8-8d63-4d5f-9b00-43667c91a485", 
        Description = "The home page for a website with an area of blocks and partial pages. ")]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "If the heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String Heading { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Footer text",
            Description = "This footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 10)]
        public virtual string FooterText { get; set; }

    }
}