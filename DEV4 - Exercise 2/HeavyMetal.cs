using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_2
{
    public class HeavyMetal : ISong
    {
        public void visit(IMusicLibraryVisitor IMLV)
        {
            IMLV.onHeavyMetal(this);
        }
    }
}
