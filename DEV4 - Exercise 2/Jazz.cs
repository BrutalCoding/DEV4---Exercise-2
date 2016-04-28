using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_2
{
    public class Jazz : ISong
    {
        public void visit(IMusicLibraryVisitor IMLV)
        {
            IMLV.onJazz(this);
        }
    }
}
