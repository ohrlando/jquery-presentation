using jQuery_Presentation_Demo1_Proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_Presentation_Demo1_Proj.Controllers
{
    public class Demo1Controller : Controller
    {
        // GET: Demo1
        public ActionResult Index()
        {
            if (Session["pessoas"] == null)
            {
                Session["pessoas"] = new List<Person>();
            }

            return View();
        }

        public ActionResult List()
        {
            return View(Session["pessoas"]);
        }

        public ActionResult Add_3()
        {
            Person p = new Person()
            {
                Nome = Request["nome"],
                Idade = Convert.ToInt32(String.IsNullOrEmpty(Request["idade"]) ? "0" : Request["idade"]),
                SobreNome = Request["sobrenome"]
            };

            if (p.Nome != null)
            {
                ((List<Person>)Session["pessoas"]).Add(p);
            }
            return View("List", Session["pessoas"]);
        }

        public ActionResult Add_2(string nome, int idade, string sobrenome)
        {
            try
            {
                Person p = new Person()
                {
                    Nome = nome,
                    Idade = idade,
                    SobreNome = sobrenome
                };

                ((List<Person>)Session["pessoas"]).Add(p);
                return View("List", Session["pessoas"]);
            }
            catch (Exception)
            {
                return View("List", Session["pessoas"]);
            }
        }

        public ActionResult Add(Person p)
        {
            if (p.Nome != null)
            {
                ((List<Person>)Session["pessoas"]).Add(p);
            }

            return View("List", Session["pessoas"]);
        }

        public JsonResult Get()
        {
            var p = new Person()
            {
                Nome = "Orlando Fernandes",
                Idade = 24,
                SobreNome = "M. Jr."
            };

            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}