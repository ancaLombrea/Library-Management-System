using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class BookDetails
    {
        public int id { get; set; }
        public int idBook { get; set; }
        //public String reviwe { get; set; }
        public String previwe { get; set; }

        public BookDetails(int id, int idBook, String preview)
        {
            this.id = id;
            //this.reviwe = reviwe;
            this.idBook = idBook;
            this.previwe = preview;
        }
    }
}
