﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    interface IForeverLove
    {
        IDictionary<string, int> items { get; }
        void additems();
    }
}
