

namespace ShopApp.DAL.Models.Employees
{
    public class EmployeesRemoveModel
    {
        public int empid { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool delete { get; set; }
    }
}
