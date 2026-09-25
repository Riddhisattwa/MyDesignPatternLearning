using System;

namespace solidlib;

public class Catalogue
{
    //composition
    private Dictionary<string, List<Book>> _catalogue = new Dictionary<string, List<Book>>();

    private void AddToCatalogue(string title, string isbn)
    {
        if(!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty("isbn"))
        {

            if(!_catalogue.TryGetValue(title, out List<Book> b1))
            {
                b1 = new List<Book>();
                b1.Add(new Book(Random.Shared.Next(1,int.MaxValue),isbn,title));
                _catalogue[title] = b1;
            }
        }
    }
}
