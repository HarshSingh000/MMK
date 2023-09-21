using System;
using System.Collections.Generic;

using CMS.SiteProvider;
using CMS.DocumentEngine;

using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using CMS.MediaLibrary;
using System.Linq;

namespace MMK.Widgets
{
    public class TextImageWidgetProperties : IWidgetProperties
    {
        public IEnumerable<MediaFilesSelectorItem> Image { get; set; } = new List<MediaFilesSelectorItem>();
        

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title", ExplanationText ="You can enter your title here.", Tooltip ="Yout Title")]
        [Required]
        public string Title { get; set; } = "Welcome to our site";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Title1", ExplanationText = "You can enter your title here.", Tooltip = "Yout Title")] 
        public string Title1 { get; set; } = "Welcome to our site";

        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 2, Label = "Description")]
        public string Description { get; set; } = "www.makemykothi.com, where a team of experts is tirelessly working towards a common mission of making your dream come true while saving you hard earned money & valuable time. With over 100 projects delivered, we bring a world class technology to our local community & neighborhood ";

        [EditingComponent(RichTextComponent.IDENTIFIER, Order = 2, Label = "Description1")]
        public string Description1 { get; set; } = "www.makemykothi.com, where a team of experts is tirelessly working towards a common mission of making your dream come true while saving you hard earned money & valuable time. With over 100 projects delivered, we bring a world class technology to our local community & neighborhood ";

        [EditingComponent(RadioButtonsComponent.IDENTIFIER, Order = 4, Label = "Image Direction")]
        [EditingComponentProperty(nameof(RadioButtonsProperties.DataSource), "LEFT;LEFT\r\nRIGHT;RIGHT")]
        [EditingComponentProperty(nameof(RadioButtonsProperties.DefaultValue), "LEFT")]
        public string ImageDirection { get; set; }

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 5, Label = "Allow Button")]
        [EditingComponentProperty(nameof(CheckBoxProperties.DefaultValue), false)]
        public bool AllowButton { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6, Label = "Button Text")]
        [VisibilityCondition(nameof(AllowButton), ComparisonTypeEnum.IsTrue)]
        public string ButtonText { get; set; } = "READ THE WHOLE STORY";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6, Label = "Button Text")]
        [VisibilityCondition(nameof(AllowButton), ComparisonTypeEnum.IsTrue)]
        public string ButtonText1 { get; set; } = "READ THE WHOLE STORY";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "Button Link")]
        [VisibilityCondition(nameof(AllowButton), ComparisonTypeEnum.IsTrue)]
        public string ButtonLink { get; set; } = "https://dotstark.com/";

        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Background color")]     
        public string bgcolor { get; set; } = "READ THE WHOLE STORY";


        
    }
}

