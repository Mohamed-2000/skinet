using System.Collections.Generic;

namespace API.Helpers
{
    public class pagination<T> where T : class
    {
        public pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        /*
   // this class help us to return pagination information to the client
   == > Total count of items Available
   == > which page number we are on 
   == > what's The page size is
*/

        public int PageIndex { get; set; }

        public int PageSize { get; set; }
        public int Count { get; set; }

        public IReadOnlyList<T> Data { get; }
    }
}
