using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSeckinMantar_Odev1_BookStore.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string SerialNumber { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }


    }
}
