using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SuyiRestApi.ATS.AtsEntities
{
    public class MentorAvailabilityEntity : TableEntity
    {
        public string MentorAvailabilityId
        {
            get
            {
                return this.PartitionKey;
            }
        }

        public DateTime StartTimePst { get; set; }

        public DateTime EndTimePst { get; set; }
        
    }
}