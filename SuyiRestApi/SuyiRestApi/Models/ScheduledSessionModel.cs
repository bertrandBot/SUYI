using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuyiRestApi.Models
{
    public class ScheduledSessionModel
    {
        public string MenteeId { get; set; }

        public string MentorId { get; set; }

        public string MenteeDisplayName { get; set; }

        public string MentorDisplayName { get; set; }

        public string TeacherName { get; set; }

        public string RoomName { get; set; }

        public DateTime StartTimePst { get; set; }

        public DateTime EndTimePst { get; set; }

        public List<string> MenteeMetadata { get; set; }

        public List<string> MentorMetadata { get; set; }
    }
}