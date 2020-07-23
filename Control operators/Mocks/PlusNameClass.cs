using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_operators.Mocks
{
    class PlusNameClass : IPlusName
    {
        IJob job;

        public PlusNameClass()
        {
            job = new PlusNameJob();

        }
        public void PlusName(int i)
        {
            job.DoJob(i);
        }
    }
}
