﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new StoreItDbContext();
            var p = ctx.People.ToList();
        }
    }
}
