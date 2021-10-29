using System;
using AdShopSolution.Data.Enums;
using System.Collections.Generic;

namespace AdShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
