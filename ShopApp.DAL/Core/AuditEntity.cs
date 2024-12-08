
namespace ShopApp.DAL.Core
{
    public abstract class AuditEntity
    {
        protected AuditEntity() 
        {
            creation_date = DateTime.Now;
            delete = false;
        }
        public DateTime creation_date { get; set; }

        public int creation_user { get; set; }

        public DateTime? modify_date { get; set; }

        public int? modify_user { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool delete { get; set; }

    }
}
