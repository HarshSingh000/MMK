using System;
using System.Linq;

using CMS.MediaLibrary;
using CMS.SiteProvider;

using MMK.Widgets;

using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

[assembly: RegisterWidget(TextImageWidgetViewComponent.IDENTIFIER, typeof(TextImageWidgetViewComponent), " & Text Image", typeof(TextImageWidgetProperties), Description = "You can enter Image, Text and Link here.", IconClass = "icon-ribbon")]
namespace MMK.Widgets
{
    public class TextImageWidgetViewComponent : ViewComponent
    {
        /// <summary>
        /// Widget identifier.
        /// </summary>
        public const string IDENTIFIER = "MMK.HomePage.TextandImage";


        private readonly IMediaFileInfoProvider mediaFileProvider;
        private readonly IMediaFileUrlRetriever fileUrlRetriever;


        /// <summary>
        /// </summary>
        /// <param name="mediaFileProvider">The media file provider.</param>
        /// <param name="fileUrlRetriever">The media file URL retriever.</param>
        public TextImageWidgetViewComponent(IMediaFileInfoProvider mediaFileProvider, IMediaFileUrlRetriever fileUrlRetriever)
        {
            this.mediaFileProvider = mediaFileProvider;
            this.fileUrlRetriever = fileUrlRetriever;
        }


        public ViewViewComponentResult Invoke(TextImageWidgetProperties properties)
        {
            var imagePath = GetImagePath(properties);
            return View("~/Components/Widgets/TextandImage/_TextImageWidget.cshtml", new TextImageWidgetViewModel
            {
                ImagePath = imagePath,
                Title = properties.Title,
                Title1 = properties.Title1,
                Description = properties.Description,
                Description1 = properties.Description1,
                ButtonLink = properties.ButtonLink,
                ImageDirection = properties.ImageDirection,
                AllowButton = properties.AllowButton,
                ButtonText = properties.ButtonText,
                ButtonText1 = properties.ButtonText1,
                bgColor=properties.bgcolor,
            });
        }


        private string GetImagePath(TextImageWidgetProperties properties)
        {
            var imageGuid = properties.Image.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            var image = mediaFileProvider.Get(imageGuid, SiteContext.CurrentSiteID);
            if (image == null)
            {
                return string.Empty;
            }

            return fileUrlRetriever.Retrieve(image).RelativePath;
        }
    }
}
