using MyBankingApp_Backing_Library.Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using MyBankingApp_Backing_API.Models;
using Moq;
using System.Collections.Generic;
using MyBankingApp_Backing_Library.Domain;

namespace MyBankingApp_Backing_API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            var myMoq = new Mock<IComptesRepository>();
            myMoq.Setup(x => x.FindAll()).Returns(new List<Compte> {
                new Compte { Numero = "Mem001", Proprietaire = "Amineeee", Solde = 1000M},
                new Compte { Numero = "Mem002", Proprietaire = "Saoudi", Solde = 1000M},
                new Compte { Numero = "Mem003", Proprietaire = "Mohamed", Solde = 1000M}});


            container.RegisterInstance<IComptesRepository>(myMoq.Object);

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IComptesRepository, ComptesRepositoryIml_Memory>(); ajouter par moi meme

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}