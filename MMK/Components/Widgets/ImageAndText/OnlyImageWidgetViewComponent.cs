using System;
using System.Linq;

using CMS.MediaLibrary;
using CMS.SiteProvider;

using MMK.Widgets;

using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

[assembly: RegisterWidget(OnlyImageWidgetViewComponent.IDENTIFIER, typeof(OnlyImageWidgetViewComponent), "Image & Text", typeof(OnlyImageWidgetProperties), Description = "You can enter Image, Text and Link here.", IconClass = "icon-ribbon")]
namespace MMK.Widgets
{
    public class OnlyImageWidgetViewComponent : ViewComponent
    {
        /// <summary>
        /// Widget identifier.
        /// </summary>
        public const string IDENTIFIER = "MMK.HomePage.ImageAndText";


        private readonly IMediaFileInfoProvider mediaFileProvider;
        private readonly IMediaFileUrlRetriever fileUrlRetriever;


        /// <summary>
        /// </summary>
        /// <param name="mediaFileProvider">The media file provider.</param>
        /// <param name="fileUrlRetriever">The media file URL retriever.</param>
        public OnlyImageWidgetViewComponent(IMediaFileInfoProvider mediaFileProvider, IMediaFileUrlRetriever fileUrlRetriever)
        {
            this.mediaFileProvider = mediaFileProvider;
            this.fileUrlRetriever = fileUrlRetriever;
        }


        public ViewViewComponentResult Invoke(OnlyImageWidgetProperties properties)
        {
            var imagePath = GetImagePath(properties);
            return View("~/Components/Widgets/ImageAndText/_OnlyImageWidget.cshtml", new OnlyImageWidgetViewModel
            {
                ImagePath = imagePath,
                Title = properties.Title,
                Description = properties.Description,
                ButtonLink = properties.ButtonLink,
                ImageDirection = properties.ImageDirection,
                AllowButton = properties.AllowButton,
                ButtonText = properties.ButtonText,
            });
        }


        private string GetImagePath(OnlyImageWidgetProperties properties)
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
