using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingService.Models;

namespace OrderProcessingService.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderModel>>GetAllOrdersAsync();
        Task<OrderModel> GetOrderByIdAsync(int orderId);
        Task CreateOrderAsync(OrderModel order);
        Task UpadteOrderAsync(OrderModel order);
        Task DeleteOrderAsync(int orderId);
    }
}