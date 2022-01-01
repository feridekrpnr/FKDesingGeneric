using FKDesignEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Abstract
{
    public interface IOrderServices
    {
        Task<IEnumerable<Order>> GetAllOrders(); //tüm siparişleri getir
        Task<Order> GetOrderById(int id); //idsi ? olan siparişi getir
        Task<Order> CreateOrder(Order order); //entity
        Task UpdateOrder(Order orderToBeUpdate, Order order);
        Task DeleteOrder(Order order);
    }
}
