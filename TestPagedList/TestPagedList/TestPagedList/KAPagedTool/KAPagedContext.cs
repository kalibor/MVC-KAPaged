using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPagedList.KAPagedTool
{
    public class KAPagedContext
    {
        public KAPagedContext(int nowpage, int pagesize)
        {
            this.NowPage = nowpage;
            this.PageSize = pagesize;
        }


        public void Init(int listcount)
        {
            SetMaxPage(listcount);
            CheckAndReviseNowPage();
            SetSkipCount();
        }

        private void SetSkipCount()
        {
            this.SkipCount = (NowPage - 1) * PageSize;
        }


        private void CheckAndReviseNowPage()
        {
            if (this.NowPage > this.MaxPage)
            {
                this.NowPage = this.MaxPage;
            }
            else if (this.NowPage <= 0)
            {
                this.NowPage = 1;
            }
        }

        private void SetMaxPage(int listcount)
        {
            int remainder = listcount % PageSize;
            int quotient = listcount / PageSize;


            if (remainder == 0)
            {
                this.MaxPage = quotient;
            }
            else
            {
                this.MaxPage = quotient + 1;
            }

        }



        public int NowPage { get; set; }
        public int PageSize { get; set; }
        public int MaxPage { get; set; }
        public int SkipCount { get; set; }

    }
}