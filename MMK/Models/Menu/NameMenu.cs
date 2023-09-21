using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;

namespace MMK.Models
{
    public class NameMenu
    {
        public string MenuName { get; set; }
        public string Link { get; set; }

        public static NameMenu Map(MenuNav article)
        {
            NameMenu menu = new NameMenu();
            menu.MenuName = article.MenuName;
            menu.Link = article.Link;
            return menu;
        }
    }
}
