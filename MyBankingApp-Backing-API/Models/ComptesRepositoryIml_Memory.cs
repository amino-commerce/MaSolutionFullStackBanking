using MyBankingApp_Backing_Library.Domain;
using MyBankingApp_Backing_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBankingApp_Backing_API.Models
{
    public class ComptesRepositoryIml_Memory : IComptesRepository
    {
        private static IEnumerable<Compte> data =  new List<Compte> { new Compte { Numero = "Mem001", Proprietaire = "Amine", Solde = 1000M},
            new Compte { Numero = "Mem002", Proprietaire = "Saoudi", Solde = 1000M},
            new Compte { Numero = "Mem003", Proprietaire = "Mohamed", Solde = 1000M}}; 
        
        //This a is async stub (Not a reastic implementation)
        public void Create(Compte c)
        {
            ((List<Compte>)data).Add(c);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            return data;
        }

        public Compte FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}