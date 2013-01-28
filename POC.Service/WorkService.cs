using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Service
{
    public class WorkService
    {
        public static ConcurrentDictionary<string,string> Data = new ConcurrentDictionary<string, string>();

        public void DoWork(string userId,string workDetail)
        {
            Data.TryAdd(userId, workDetail);
        }
    }
}
