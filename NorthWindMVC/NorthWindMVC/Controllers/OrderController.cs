﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWindMVC.Models;

namespace NorthWindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return RedirectToAction("FindOrderByID");
        }
        public ActionResult ListAllOrders()
        {
            List<Order> orders = _repositoryOrders.AllOrders();
            return View(orders);
        }
        public ActionResult FindOrderByID()
        {
            RepositoryOrders repository = _repositoryOrders;
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            return View(orderIds);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            Order order = new Order();
            order = _repositoryOrders.FindOrderById(id);
            return View(order);
        }
        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
