using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Shippers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Daos
{
    internal class DaoShippers : IDaoShippers
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoShippers(ShopContext context, ILogger<DaoSuppliers> logger)
        {
            _logger = logger;
            _shopContext = context;
        }
        public void CreateShippers(ShippersCreateOrUpdateModel shippers)
        {
            throw new NotImplementedException();
        }

        public List<GetShippers> GetShippers()
        {
            throw new NotImplementedException();
        }

        public GetShippers GetShippersById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveShippers(ShippersRemoveModel shippers)
        {
            throw new NotImplementedException();
        }

        public void UpdateShippers(ShippersCreateOrUpdateModel shippers)
        {
            throw new NotImplementedException();
        }
    }
}
