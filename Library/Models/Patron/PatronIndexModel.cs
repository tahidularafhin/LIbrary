using System.Collections.Generic;

namespace Library.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; } //this actually i will return the patron Index view

    }
}
