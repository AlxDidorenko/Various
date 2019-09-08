using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processes
{
    class Process
    {
        private string name;
        private int basep;
        private int curp;
        private int acticks;

        public int BasePublic
        {
            get
            {
                return basep;
            }
        }
        public int CurPublic
        {
            get
            {
                return curp;
            }
            set
            {
                curp = value;
            }
        }

        public Process(string n, int bp)
        {
            this.name = n;
            this.basep = bp;
        }
    }
}