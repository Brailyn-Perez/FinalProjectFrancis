
using ShopApp.DAL.Models.Orders;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoOrders
    {
        void CreateOrders(OrdersCreateOrUpdateModel orders);

        void UpdateOrders(OrdersCreateOrUpdateModel orders);

        void RemoveOrders(OrdersRemoveModel orders);

        List<GetOrders> GetOrders();

        GetOrders GetOrdersById(int id);

    }
}
