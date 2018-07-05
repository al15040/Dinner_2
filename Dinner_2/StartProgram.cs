using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_2
{
    class StartProgram
    {
        public static void Main()
        {
            DinnerViewer viewer = new DinnerViewer("./dinner.txt");
            var task = Task.Run(() => Application.Run(viewer));

            while (true)
            {
               if ( viewer.IsDisposed ) break;
               Thread.Sleep(50);
               viewer.setLabelRandom();
            }
            
        }
    }
}
