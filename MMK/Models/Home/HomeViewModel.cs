using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace MMK.Models
{
    public class HomeViewModel
    {
        public IEnumerable<ContactModel > ContactViewModel { get; set; }
        public IEnumerable<GalleryModel> GalleryViewModel { get; set; }
    
}
}
