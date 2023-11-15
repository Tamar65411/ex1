﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrdersService : IOrdersService
    {
        private IOrderRepository repository;
        public OrdersService(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public async Task<OrdersTbl> addNewOrder(OrdersTbl newOrder)
        {
            return await repository.addNewOrder(newOrder);


        }
    }
}
