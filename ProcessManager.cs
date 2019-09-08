using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processes
{
    class ProcessManager
    {
        private List<Process> pr;

        public void AddProcess(string name, int basepr)
        {
            pr.Add(new Process(name, basepr));
        }

        public void Transposition()
        {
            int max = 0;
            int indxb = 0;
            foreach (Process prio in pr)
            {
                if (prio.BasePublic > max)
                {
                    max = prio.BasePublic;
                    indxb = pr.IndexOf(prio);
                }
            }
            foreach (Process prior in pr)
            {
                prior.CurPublic = prior.BasePublic + 1;
                //pr.Insert(indxb, max); Как в текущий приоритет положить на этот же процесс поставить максимальный базовый приоритет?
            }

        }
    }
}
