using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrnetapp1
{
    public class Engine
    {
        public Engine()
        {

        }

        public void DoWork()
        {
            Task T1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("This is from worker thread.");
            });

            Task T2 = T1.ContinueWith(t =>
            {

                Console.WriteLine("Back on main thread.");

            });
        }

    }
}
