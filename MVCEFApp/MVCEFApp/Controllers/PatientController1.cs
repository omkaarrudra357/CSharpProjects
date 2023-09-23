﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFApp.Models;

namespace MVCEFApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: DoctorController1
        public ActionResult Index()
        {
            List<Patient> patient = RepositoryPatient.GetPatient();
            if (patient != null && patient.Count>0)
            {
                return View(patient);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: DoctorController1/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = new Patient();
            return View(patient);
        }

        // GET: DoctorController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Patient ppatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(ppatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: DoctorController1/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View();
        }

        // POST: DoctorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Patient patient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.ModifyPatient(patient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController1/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: DoctorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.RemovePatient(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
