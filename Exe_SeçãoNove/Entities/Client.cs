using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_SeçãoNove.Entities
{
    class Client
    {
        public String name { get; set; }
        public String email { get; set; }
        public DateTime birthDate{ get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Construindo um StringBuilder
            sb.AppendLine(name);
            sb.Append(birthDate.ToString("(dd/MM/yyyy)"));
            sb.Append(" - ");
            sb.Append(email);
            return sb.ToString();
        }
    }
}
