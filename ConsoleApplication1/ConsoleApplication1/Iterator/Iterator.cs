using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Iterator
{
    public interface Iterator
    {
        bool hasNext();
        object Next();
    }
}
