﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.BLL.IDataRepos
{
    public interface IOrderRepo
    {
        bool CheckOrderExists(int orderId);
        void AddCupcakeOrder(int locationId, int customerId);
        void AddCupcakeOrderItems(int orderId, Dictionary<int, int> cupcakeInputs);
        int GetLastCupcakeOrderAdded();
        Project1.BLL.Order GetCupcakeOrder(int orderId);
        IEnumerable<Project1.BLL.Order> GetAllOrders();
        IEnumerable<Project1.BLL.OrderItem> GetAllOrderItems();
        IEnumerable<Project1.BLL.OrderItem> GetOrderItems(int orderId);
        IEnumerable<Project1.BLL.Order> GetCustomerOrderHistory(int customerId);
        IEnumerable<Project1.BLL.OrderItem> GetCustomerOrderItems(int customerId);
    }
}