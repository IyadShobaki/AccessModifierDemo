﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            PrivateProtectedDemo();
            ProtectedDemo();
            ProtectedInternalDemo();
            InternalDemo();
            PublicDemo();
          
        }
    }
}
