
using ShopApp.DAL.Models.Customers;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoCustomers
    {
        void CreateCustomers(CustomersCreateOrUpdateModel customers);

        void UpdateCustomers(CustomersCreateOrUpdateModel customers);

        void RemoveCustomers(CustomersRemoveModel customers);

        GetCustomers GetCustomersById();

        List<GetCustomers> GetCustomers();
    }
}
