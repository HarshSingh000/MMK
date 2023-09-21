using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;
namespace MMK.Models
{
    public class ContactModel
    {
        public string Location { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
        public string GoogleMapLink { get; set; }

        public static ContactModel Map(ContactDeails contacts)
        {
            ContactModel contact = new ContactModel();
            contact.Location = contacts.Location;
            contact.Email = contacts.Email;
            contact.Call = contacts.Call.ToString();
            contact.GoogleMapLink = contacts.Google_Map_Link;
            return contact;
        }
    }
}
