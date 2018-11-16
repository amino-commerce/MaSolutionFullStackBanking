using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankingApp_Backing_Library.Domain
{
    public class Compte
    {
        public string Numero { get; set; }
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }
    }
}
