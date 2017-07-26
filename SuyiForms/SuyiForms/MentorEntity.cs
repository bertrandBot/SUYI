using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SuyiRestApi.ATS.AtsEntities
{
    public class MentorEntity : TableEntity
    {
        public string QuarterId
        {
            get
            {
                return this.PartitionKey;
            }
        }

        public string SeattleUId
        {
            get
            {
                return this.RowKey;
            }
        }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Colleges { get; set; }
        
        public string Comments { get; set;

        }
    }
}