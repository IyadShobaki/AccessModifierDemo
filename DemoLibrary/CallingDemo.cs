using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();
            //will call public, protectedInternal and internal methods

            demo.PublicDemo();
            demo.ProtectedInternalDemo();
            demo.InternalDemo();
        }
    }
}
