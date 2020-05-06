using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleDemo.Models;

namespace SampleDemo.Controllers
{
    public class DemoController : Controller
    {
        public DemoController()
        {

        }
        public IActionResult Index()
        {
            // 1. *************RETRIEVE ALL NAMES DETAILS ******************
            // GET: Names
            try
            {
                List<Name> myList = new List<Name>();                
                myList = NameDB.GetNames();
                ModelState.Clear();
                return View(myList);
            }
            catch (Exception ex)
            {
                return View();                
            }           
        }

        public IActionResult ShowData()
        {
            // 1. *************RETRIEVE ALL NAMES DETAILS ******************
            // GET: Names
            try
            {
                List<Name> myList = new List<Name>();
                //Name tmp1 = new Name() { ID = 1, FirstName = "Dan", LastName = "Test" };
                //Name tmp2 = new Name() { ID = 2, FirstName = "Tom", LastName = "Brady" };
                //myList.Add(tmp1);
                //myList.Add(tmp2);
                myList = NameDB.GetNames();
                ModelState.Clear();
                return View(myList);
            }
            catch (Exception ex)
            {
                return View();
                //throw;
            }            
        }

        // 2. *************ADD A NEW NAME RECORD ******************
        // GET: Name/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Name/Create
        [HttpPost]
        public IActionResult Create(Name objModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (NameDB.AddName(objModel))
                    {
                        ViewBag.Message = "Name has been successfully added.";
                        ModelState.Clear();
                    }

                }
                return View();

            }
            catch (Exception)
            {
                return View();
            }            
        }

        // 3. ************* EDIT NAME DETAILS ******************
        // GET: Name/Edit/3

        public IActionResult Edit(int id)
        {
            Name objTest = new Name();
            objTest= NameDB.GetName(id);
            return View(objTest);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Name objTemp)
        {
            try
            {
                bool updateFlag = NameDB.UpdateName(objTemp);
                
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }            
        }

        // 4. ************* DELETE NAME DETAILS ******************
        // GET: Name/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                bool deleteFlag = NameDB.DeleteName(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public IActionResult Detail(int id)
        {            
             Name objTest = new Name();
             objTest = NameDB.GetName(id);
             return View(objTest);
            
        }

    }
}