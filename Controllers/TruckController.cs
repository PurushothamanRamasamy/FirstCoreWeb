using FirstCoreWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWeb.Controllers
{
    public class TruckController : Controller
    {
        public Truck truck = new Truck();
        public static List<Truck> trucks = Truck.AllTrucks();

        // GET: TruckController
        public IActionResult Trucks()
        {
            
            return View(trucks);
        }

        // GET: TruckController/Details/5
        public ActionResult Details(string id)
        {
           Truck detailsTruck= trucks.FirstOrDefault(trk => trk.TruckNumber == id);
            return View(detailsTruck);
        }

        // GET: TruckController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TruckController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Truck addtruck)
        {
            try
            {

                truck.AddTruck(addtruck);
                return RedirectToAction("Trucks");
            }
            catch
            {
                return View();
            }
        }

        // GET: TruckController/Edit/5
        public ActionResult Edit(string id)
        {
            Truck detailsTruck = trucks.FirstOrDefault(trk => trk.TruckNumber == id);
            return View(detailsTruck);
        }

        // POST: TruckController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Truck edittruck)
        {
            try
            {
                
                truck.UpdateTruck(edittruck);
                return RedirectToAction("Trucks");
            }
            catch
            {
                return View();
            }
        }

        // GET: TruckController/Delete/5
        public ActionResult Delete(string id)
        {
            Truck detailsTruck = trucks.FirstOrDefault(trk => trk.TruckNumber == id);
            truck.DeleteTruck(detailsTruck);
            return RedirectToAction("Trucks");
            /*return View(detailsTruck);*/
        }

        // POST: TruckController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Truck removetruck)
        {
            try
            {
                truck.DeleteTruck(removetruck);
                return RedirectToAction("Trucks");
            }
            catch
            {
                return View();
            }
        }
    }
}
