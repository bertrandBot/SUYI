using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuyiRestApi.Models
{
    public class CandidateMatchModel
    {
        public string matchId { get; set; }

        public string mentorName { get; set; }

        public string teacherName { get; set; }

        public string roomName { get; set; }

        public string mentorMetadata { get; set; }

        public DateTime startTimePst { get; set; }

        public DateTime endTimePst { get; set; }
    }
}