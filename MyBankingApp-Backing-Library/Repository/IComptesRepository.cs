using MyBankingApp_Backing_Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankingApp_Backing_Library.Repository
{
    public interface IComptesRepository
    {
        //CRUD Facade
        IEnumerable<Compte> FindAll();
        Compte FindById(String id);
        void Update(Compte c);
        void Delete(String id);
        void Create(Compte c);
    }
}
