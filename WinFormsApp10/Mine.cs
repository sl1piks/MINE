using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp10
{
    internal class Mine
    {
        public int Ore { get; set; }
        public int Worker { get; set; }   

        public void Tick()
        {
            Ore += Worker;
        }
    }
}
