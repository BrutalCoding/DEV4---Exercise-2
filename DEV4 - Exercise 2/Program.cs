using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV4___Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicLibraryVisitor MLV = new MusicLibraryVisitor();
            MLV.onHeavyMetal(new HeavyMetal());
            MLV.onHeavyMetal(new HeavyMetal());
            MLV.onHeavyMetal(new HeavyMetal());
            MLV.onJazz(new Jazz());
            MLV.onJazz(new Jazz());
            Console.WriteLine(String.Format("Heavymetal songs amount: {0} \nJazz songs amount: {1}", MLV.listHM.Count, MLV.listJ.Count));
            Console.ReadLine();
        }
    }
}
