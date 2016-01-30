using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTankApp.Models
{
    public class IntHistoryModel
    {
        public IntHistoryModel(DateTime timesStamp, int value)
        {
            this.TimeStamp = timesStamp;
            this.Value = value;    
        }

        public DateTime TimeStamp { get; set; }
        public int Value { get; set; }
    }
}
