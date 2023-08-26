using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class CarController : Controller
    {
        //get obtener
        //put mandar indorm
        //post mandar 
        //localoshgoy:9t9/car/index
        // GET: Car
        [Route("Car/Index")]
        public ActionResult Index()
        {
            List<Car> carModel = new List<Car>();
            carModel.Add(new Car()
            {
                id = 1,
                description = "carro rojo",
                name = "carro 1",
            });
            carModel.Add(new Car()
            {
                id = 2,
                description = "carro azul",
                name = "carro 2",
            });
            return View(carModel);
        }
        //locahost:8080/Car/SearchByName/4
        [Route("Car/SearchByName/{carro}")]
        public ActionResult SearchByName(string carro) {
            List<Car> carModel = new List<Car>();
            carModel.Add(new Car()
            {
                id = 1,
                description = "carro rojo",
                name = "carro 1",
            });
            carModel.Add(new Car()
            {
                id = 2,
                description = "carro azul",
                name = "carro 2",
            });
            //linqi ui
            Car search = new Car();

            search = 
                carModel.Where(x => x.name.Contains(carro)).FirstOrDefault();
            if(search == null) {
                return RedirectToRoute("Car/Index");
            }
            return View(search);
        }

    }
}