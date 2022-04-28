using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sabzishop.Models.Pagination
{
    public class Pagination<T>:List<T>
    {
        public int pageItem { get; private set; }
        public int  totalpages { get; set; }

        public Pagination(List<T> items, int count, int pageindex, int pagesize)
        {
           pageItem=pageindex;
            totalpages=(int)Math.Ceiling(count / (double) pagesize);
            this.AddRange(items);
        } 

        public bool previouspage
        {
            get
            {
                return (pageItem > 1);
            }
        }

        public bool nextpage
        {
            get
            {
                return (pageItem < totalpages);
            }
        }

        public static async Task<Pagination<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pagesize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pagesize).Take(pagesize).ToListAsync();
            return new Pagination<T>(items, count, pageIndex, pagesize);
        }

    }
}
