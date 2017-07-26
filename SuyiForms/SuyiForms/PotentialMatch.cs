using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuyiForms
{
    public class PotentialMatch
    {
        public static PotentialMatch CreateHeader()
        {
            return new PotentialMatch
            {
                DayOfTheWeek = "Day of Week",
                Period = "Period",
                TeacherName = "Teacher name",
                SuggestedMentor = "Suggested mentor"
            };
        }

        public string DayOfTheWeek { get; set; }

        public string Period { get; set; }

        public string TeacherName { get; set; }

        public string SuggestedMentor { get; set; }

        public string MenteeId { get; set; }

        public string MentorId { get; set; }

        public string MenteeAvailabilityId { get; set; }

        public string MentorAvailabilityId { get; set; }

        public override string ToString()
        {
            return DayOfTheWeek + GenerateSpacing(DayOfTheWeek.Length) + Period + GenerateSpacing(Period.Length) + TeacherName + GenerateSpacing(TeacherName.Length) + SuggestedMentor;
        }

        public string GenerateSpacing(int previousSegmentLength)
        {
            string spaceString = string.Empty;
            for (int i = 0; i < (20 - previousSegmentLength); i++)
            {
                spaceString += " ";
            }

            return spaceString;
        }
    }
}
