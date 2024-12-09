using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Daos
{
    public class DaoCustomers : IDaoCustomers
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoCustomers(ILogger logger, ShopContext shopContext)
        {
            _logger = logger;
            _shopContext = shopContext;
        }

        public void CreateCustomers(CustomersCreateOrUpdateModel customers)
        {
            throw new NotImplementedException();
        }

        public List<GetCustomers> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public GetCustomers GetCustomersById()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomers(CustomersRemoveModel customers)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomers(CustomersCreateOrUpdateModel customers)
        {
            throw new NotImplementedException();
        }
    }
}
