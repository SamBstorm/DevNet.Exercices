using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Structures_Bonus01
{
    public struct Contact
    {
        public string prenom;
        public string nom;
        public DateTime dateDeNaissance;
        public List<Email> emails;
        public List<Telephone> telephones;
    }
}
