﻿

namespace ShopApp.DAL.Models.Categories
{
    public class GetCategories
    {
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public string description { get; set; }

        public DateTime creation_date { get; set; }
    }
}
