using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    /*
     // class Responsibilities
        == store ProductsController GetProducts() Action parameters
        == Set maximum page size
        == Set Default Page Index
        ==  Set Default Page Size
     */
    public class ProductSpecParams
    {
        private int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;
        private int _PageSize = 6; //backing field

        public int PageSize 
        {
            get => _PageSize;
            // pervent us from returning more than 50 result for a single request
            set => _PageSize = (value > MaxPageSize ? MaxPageSize : value);
        }

        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public string Sort { get; set; }

        private string _search;
        public string Search
        {
            get => _search;
            set => _search = value.ToLower();

        }

    }
}
