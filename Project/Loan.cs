using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Loan
    {
        public int id { get; set; }
        public int idClient { get; set; }
        public int idBook { get; set; }
        public Boolean returned { get; set; }

        public Loan(int id, int idClient, int idBook)
        {
            this.id = id;
            this.idClient = idClient;
            this.idBook = idBook;
            this.returned = false;
        }
        public Loan(int id, int idClient, int idBook, bool returned)
        {
            this.id = id;
            this.idClient = idClient;
            this.idBook = idBook;
            this.returned = returned;
        }
    }
}
