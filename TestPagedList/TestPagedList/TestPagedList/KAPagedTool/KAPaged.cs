using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace TestPagedList.KAPagedTool
{
    public class KAPaged<T> : KAPagedBase<T>
    {
        public KAPaged(IEnumerable<T> datalist, KAPagedContext context)
        {
            context.Init(datalist.Count());
            this.PagedContext = context;

            this._dataList = datalist.Skip(context.SkipCount).Take(context.PageSize).ToList();
        

        }

        public KAPaged(IQueryable<T> datalist, KAPagedContext context)
        {
            context.Init(datalist.Count());
            this.PagedContext = context;

            this._dataList = datalist.Skip(context.SkipCount).Take(context.PageSize).ToList();
           
         
        }

    }
}