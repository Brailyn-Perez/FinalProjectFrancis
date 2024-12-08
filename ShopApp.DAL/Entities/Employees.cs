
using ShopApp.DAL.Core;
using System.Runtime.CompilerServices;

namespace ShopApp.DAL.Entities
{
    public class Employees : PhoneContactEntity
    {
        public int empid { get; set; }

        public string lastname { get; set; }

        public string firstname { get; set; }

        public string title { get; set; }

        public string titlecourtesy { get; set; }

        public DateTime birthdate { get; set; }

        public DateTime hiredate { get; set; }

        public int? mgrid { get; set; }

    }
}
