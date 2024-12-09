
using ShopApp.DAL.Models.Supliers;

namespace ShopApp.DAL.Interfaces
{
    internal interface IDaoSuppliers
    {
        void CreateSuppliers(SuppliersCreateOrUpdateModel suppliers);

        void UpdateSuppliers(SuppliersCreateOrUpdateModel suppliers);

        void RemoveSuppliers(SuppliersRemoveModel suppliers);

        List<GetSuppliers> GetSuppliers();

        GetSuppliers GetSuppliersById(int id);
    }
}
