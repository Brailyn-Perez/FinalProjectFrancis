
using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Supliers;

namespace ShopApp.DAL.Daos
{
    internal class DaoSuppliers : IDaoSuppliers
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoSuppliers(ShopContext context , ILogger<DaoSuppliers> logger) 
        {
            _logger = logger;
            _shopContext = context;
        }
        public void CreateSuppliers(SuppliersCreateOrUpdateModel suppliers)
        {
            throw new NotImplementedException();
        }

        public List<GetSuppliers> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public GetSuppliers GetSuppliersById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSuppliers(SuppliersRemoveModel suppliers)
        {
            throw new NotImplementedException();
        }

        public void UpdateSuppliers(SuppliersCreateOrUpdateModel suppliers)
        {
            throw new NotImplementedException();
        }
    }
}
