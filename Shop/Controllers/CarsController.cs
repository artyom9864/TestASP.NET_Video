using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller

    {
        private readonly IAll _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAll iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }


        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили: ";
            return View(obj);
        }



    }
}
