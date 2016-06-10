using TrabalhoAngular.Models.Inscricoes;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Mvc;



namespace TrabalhoAngular.Controllers

{

    public class HomeController : Controller

    {

        private InscricaoFactory inscricaoFactory = new InscricaoFactory();

        public ActionResult Index()

        {

            return View("Index", "", inscricaoFactory.BuildInscricao());

        }

    }

}

