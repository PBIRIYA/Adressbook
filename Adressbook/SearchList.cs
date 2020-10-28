using Addressbook;
using System;
using System.Collections.Generic;
using System.Text;
namespace Adressbook
{
    class SearchList
    {
        public Dictionary<string, HashSet<Contact>> GeneralDictionary = new Dictionary<string, HashSet<Contact>>();
        public static List<Contact> SearchByCity()
        {
            Contact contact = new Contact();
            List<Contact> ContactsByCity = new List<Contact>();
            Dictionary<string, List<Contact>> CityDictionary = new Dictionary<string, List<Contact>>();
            Console.WriteLine("Enter the city: ");
            string city = Console.ReadLine();
            if (contact.City == city)
            {
                ContactsByCity.Add(contact);
                CityDictionary.Add(city, ContactsByCity);
            }
            Console.WriteLine(ContactsByCity);
            return ContactsByCity;
        }
    }
}
