using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace submodule
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOwner g = new GetOwner();
            var name = g.GetOwnerName();
        }
    }
}
