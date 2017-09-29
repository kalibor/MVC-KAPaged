using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPagedList.KAPagedTool
{
    public class KAPagedBase<T> : IEnumerable<T>, IEnumerator<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return _dataList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (_poision < _dataList.Count())
            {
                _poision++;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Reset()
        {
            _poision = -1;
        }

        public void Dispose()
        {
            this.Dispose();
        }



        public KAPagedContext PagedContext { get; set; }


        protected List<T> _dataList { get; set; }
        private int _poision { get; set; }


        public T Current { get { return _dataList[_poision]; } }
        object IEnumerator.Current { get { return Current; } }
    }
}