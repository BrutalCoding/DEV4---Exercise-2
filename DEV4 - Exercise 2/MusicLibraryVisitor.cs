using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_2
{
    class MusicLibraryVisitor : IMusicLibraryVisitor
    {
        public List<HeavyMetal> listHM = new List<HeavyMetal>();
        public List<Jazz> listJ = new List<Jazz>();
        public void onHeavyMetal(HeavyMetal HM)
        {
            listHM.Add(HM);
        }

        public void onJazz(Jazz j)
        {
            listJ.Add(j);
        }
    }
}
