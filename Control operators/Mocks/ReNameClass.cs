using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_operators
{
    class ReNameClass : IReName
    {
        IJob job;
        
        public ReNameClass()
        {
            
            job = new ReNameJob();
        }

       public void ReName(int i)
        {
            job.DoJob(i);
        }
    }
}
