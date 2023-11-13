using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShiftDTO
    {
        private string id;
        private DateTime workingDate;
        private string startTime;
        private string endTime;
        public ShiftDTO(string id, DateTime workingDate, string startTime, string endTime)
        {
            this.id = id;
            this.workingDate = workingDate;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string Id { get { return id; } set { id = value; } }
        public DateTime WorkingDate { get { return workingDate; } set { workingDate = value; } }
        public string StartTime { get { return startTime; } set { startTime = value; } }
        public string EndTime { get { return endTime; } set { endTime = value; } }
    }
}
