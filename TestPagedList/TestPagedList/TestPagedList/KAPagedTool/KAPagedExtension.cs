using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPagedList.KAPagedTool
{
    public static class KAPagedExtension
    {
   
        public static KAPaged<T> ToKAPaged<T>(this IQueryable<T> datalist, KAPagedContext context)
        {
            KAPaged<T> Paged = new KAPaged<T>(datalist, context) ;
            return Paged;
        }

        public static KAPaged<T> ToKAPaged<T>(this IEnumerable<T> datalist, KAPagedContext context)
        {
            KAPaged<T> Paged = new KAPaged<T>(datalist, context);
            return Paged;
        }

    }
}