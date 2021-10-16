using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpec : BaseSpecification<Product>
    {
        /*
            this class gives us the count of all items after the filter have been applied 
            before pagination and sorting
         */
        public ProductWithFiltersForCountSpec(ProductSpecParams ProductParams)
             : base(x =>
                 (string.IsNullOrEmpty(ProductParams.Search) || x.Name.ToLower().Contains(ProductParams.Search))&&
                 (!ProductParams.BrandId.HasValue || x.ProductBrandId == ProductParams.BrandId) &&
                 (!ProductParams.TypeId.HasValue || x.ProductTypeId == ProductParams.TypeId))
        {
        }
    }
}
