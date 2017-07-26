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
        public string quarterName
        {
            get
            {
                return this.RowKey;
            }
        }
    }
}