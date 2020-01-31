﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox_Lib.Interfaces;
using PizzaBox_Web.Models;

namespace PizzaBox_Web.Controllers
{
    public class OrderHistoryController : Controller
    {
        private readonly IPizzaBoxRepository _repository;
        public OrderHistoryController(IPizzaBoxRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var orders = _repository.GetOrders();

            //List<Orders> orderList = new List<Orders>();
            //foreach (var item in orders)
            //{
            //    Orders order = new Orders
            //    {
            //        Pizzas = item.Pizzas,
            //        Userid = item.Userid,
            //        Storeid = item.Storeid,
            //        TimeOrdered = item.TimeOrdered,
            //        Total = item.Total
            //    };
            //    orderList.Add(order);
            //}
             

            return View(orders.ToList());
        }
    }
}