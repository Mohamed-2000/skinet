using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecification(ProductSpecParams ProductParams)
            : base(x =>
                 (string.IsNullOrEmpty(ProductParams.Search) || x.Name.ToLower().Contains(ProductParams.Search))&&
                 (!ProductParams.BrandId.HasValue || x.ProductBrandId == ProductParams.BrandId) &&
                 (!ProductParams.TypeId.HasValue || x.ProductTypeId == ProductParams.TypeId))
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            // default ordering
            AddOrderBy(x => x.Name);

            ApplyPaging(ProductParams.PageSize * (ProductParams.PageIndex - 1), ProductParams.PageSize);

            if (!string.IsNullOrEmpty(ProductParams.Sort))
            {
                switch (ProductParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(d => d.Name);
                        break;
                }
            }
        }

        public ProductWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
