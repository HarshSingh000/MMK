using System;
using System.Linq;

using CMS.MediaLibrary;
using CMS.SiteProvider;

using MMK.Widgets;

using Kentico.Content.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;


[assembly: RegisterWidget(SearchWidgetViewComponents.IDENTIFIER, typeof(SearchWidgetViewComponents), "Search Widgets", typeof(SearchWidgetProperties), Description = "Search Widgets can be added", IconClass = "icon-ribbon")]

namespace MMK.Widgets
{
    public class SearchWidgetViewComponents : ViewComponent
    {
        public const string IDENTIFIER = "MMK.HomePage.Serach";


        private readonly IMediaFileInfoProvider mediaFileProvider;
        private readonly IMediaFileUrlRetriever fileUrlRetriever;


        /// <summary>
        /// </summary>
        /// <param name="mediaFileProvider">The media file provider.</param>
        /// <param name="fileUrlRetriever">The media file URL retriever.</param>
        public SearchWidgetViewComponents(IMediaFileInfoProvider mediaFileProvider, IMediaFileUrlRetriever fileUrlRetriever)
        {
            this.mediaFileProvider = mediaFileProvider;
            this.fileUrlRetriever = fileUrlRetriever;
        }


        public ViewViewComponentResult Invoke(SearchWidgetProperties properties)
        {
            
            return View("~/Components/Widgets/Search/_searchWidget.cshtml", new SearchWidgetViewModel
            {

                Placeholder = properties.Placeholder,
                Button = properties.Button,
               
            });
        }
    }
}
