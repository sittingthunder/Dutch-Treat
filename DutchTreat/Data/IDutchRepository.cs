﻿using System.Collections.Generic;
using DutchTreat.Controllers;
using DutchTreat.Data.Entities;

namespace DutchTreat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductByCategory(string category);

        bool SaveAll();

        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string userName, bool includeItems);

        Order GetOrderById(string userName, int id);
        void AddEntity(object model);
        
    }
}