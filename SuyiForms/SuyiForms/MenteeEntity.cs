using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SuyiRestApi.ATS.AtsEntities
{
    public class MenteeEntity : TableEntity
    {
        [XmlIgnore]
        public string QuarterName
        {
            get
            {
                return this.PartitionKey;
            }
        }

        [XmlIgnore]
        public string MenteeId
        {
            get
            {
                return this.RowKey;
            }
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}