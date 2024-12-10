

using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Categories : AuditEntity
    {
        [Key]
        public int categoryid { get; set; }

        public string categoryName { get; set; }

        public string description { get; set; }


    }
}
