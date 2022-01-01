using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKDesignBusiness.Concrete
{
    public class OrderServices : IOrderServices
    {
        private IUnitOfWork _unitOfWork;
        public OrderServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Order> CreateOrder(Order order)
        {
            await _unitOfWork.Orders.AddAsync(order);
            return order;
        }

        public async Task DeleteOrder(Order order)
        {
            _unitOfWork.Orders.Remove(order);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _unitOfWork.Orders.GetAllAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _unitOfWork.Orders.GetByIdAsync(id);
        }

        public async Task UpdateOrder(Order orderToBeUpdate, Order order)
        {
            orderToBeUpdate.OrderName = order.OrderName;
            await _unitOfWork.CommitAsync();
        }
    }
}
