using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Librarian
    {
        public int id { get; set; }
        public string password { get; set; }
        public string username { get; set; }

    public Librarian(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

    }
}
