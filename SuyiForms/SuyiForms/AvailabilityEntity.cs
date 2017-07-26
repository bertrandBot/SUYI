using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SuyiRestApi.ATS.AtsEntities
{
    public class AvailabilityEntity : TableEntity
    {
        public string QuarterId
        {
            get
            {
                return this.PartitionKey;
            }
        }

        public string AvailabilityId
        {
            get
            {
                return this.RowKey;
            }
        }

        public string UserId { get; set; }

        public DateTime StartTimePst { get; set; }

        public DateTime EndTimePst { get; set; }
        
        public string TeacherName { get; set; }

        public string PeriodName { get; set; }

        public string DayOfTheWeek { get; set; }

        public override string ToString()
        {
            return this.PartitionKey + this.RowKey;
        }
    }
}