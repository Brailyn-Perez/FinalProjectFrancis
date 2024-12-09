
using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Orders;

namespace ShopApp.DAL.Daos
{
    public class DaoOrders : IDaoOrders
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoOrders(ShopContext context, ILogger<DaoSuppliers> logger)
        {
            _logger = logger;
            _shopContext = context;
        }
        public void CreateOrders(OrdersCreateOrUpdateModel orders)
        {
            throw new NotImplementedException();
        }

        public List<GetOrders> GetOrders()
        {
            throw new NotImplementedException();
        }

        public GetOrders GetOrdersById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrders(OrdersRemoveModel orders)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrders(OrdersCreateOrUpdateModel orders)
        {
            throw new NotImplementedException();
        }
    }
}
