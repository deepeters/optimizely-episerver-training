using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "SVG File", 
        GUID = "58d0b53d-8b92-4796-95c9-1f4fa5432f1c", 
        Description = "Use this to upload Scalable Vector Graphic (SVG) Images. ")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : MediaData
    {
        // instead of generating a smaller bitmap file for thumbnail,
        // use the same binary vector image for thumbnail
        public override Blob Thumbnail { get => base.BinaryData; /*set => base.Thumbnail = value; */}
    }
} 