using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Services
{
    public class RecordService : IRecordService
    {
        public void GetRecords()
        {
            int totalRecords = 20000;
            int currentRecord = 0;

            while (currentRecord < totalRecords)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
