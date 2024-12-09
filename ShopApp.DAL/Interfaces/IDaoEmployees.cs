

using ShopApp.DAL.Models.Employees;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoEmployees
    {
        void CreateEmployees(EmployeesCreateOrUpdateModel employees);

        void UpdateEmployees(EmployeesCreateOrUpdateModel employees);

        void RemoveEmployees(EmployeesRemoveModel employees);

        List<GetEmployees> GetEmployees();

        GetEmployees GetEmployeesById(int id);
    }
}
