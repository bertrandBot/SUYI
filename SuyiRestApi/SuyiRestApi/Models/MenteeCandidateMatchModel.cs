using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuyiRestApi.Models
{
    public class MenteeCandidateMatchModel
    {
        [Display(Name = "MenteeId")]
        public string MenteeId { get; set; }

        public string MenteeDisplayName { get; set; }

        public List<string> MenteeMetadata { get; set; }

        public List<CandidateMatchModel> CandidateMatches { get; set; }
    }
}