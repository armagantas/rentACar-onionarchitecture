﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging
{
    public class Paginate<T>
    {
        public int Index { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public IList<T> Items { get; set; }

        public Paginate()
        {
            Items = Array.Empty<T>();
        }

        public bool HasPrevious => Index > 0;
        public bool HasNext => Index+1 < Pages;

    }
}
