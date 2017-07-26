using SuyiRestApi.ATS;
using SuyiRestApi.ATS.AtsEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuyiForms
{
    public partial class form : Form
    {
        private AzureTableStorageProvider atsProvider;
        private List<MenteeEntity> mentees;
        private List<MentorEntity> mentors;
        private List<AvailabilityEntity> menteeAvailabilities;
        private List<AvailabilityEntity> mentorAvailabilities;

        public form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {
            atsProvider = new AzureTableStorageProvider();

            var quarters = atsProvider.FetchEntities<QuarterEntity>("Quarter", TableType.Quarter);

            foreach (var quarter in quarters)
            {
                cb_Quarter.Items.Add(quarter);
            }

            cb_Quarter.SelectedItem = cb_Quarter.Items[0];

            var quarterId = ((QuarterEntity)cb_Quarter.SelectedItem).ToString();
            ReloadMatches(quarterId);
        }

        private void ReloadMatches(string quarterId)
        {
            mentees = atsProvider.FetchEntities<MenteeEntity>(quarterId, TableType.Mentee);

            lb_Mentees.Items.Clear();
            foreach (var mentee in mentees)
            {
                lb_Mentees.Items.Add(mentee.Name);
            }

            mentors = atsProvider.FetchEntities<MentorEntity>(quarterId, TableType.Mentor);
            mentorAvailabilities = atsProvider.FetchEntities<AvailabilityEntity>(quarterId, TableType.MentorAvailability);
            menteeAvailabilities = atsProvider.FetchEntities<AvailabilityEntity>(quarterId, TableType.MenteeAvailability);

            var potentialAvailabilityMatches = new List<AvailabilityEntity>();
            lb_Matches.Items.Clear();
            lb_Matches.Items.Add(PotentialMatch.CreateHeader(), true);

            foreach (var mentee in mentees)
            {
                var matchingAvailabilities = menteeAvailabilities.Where(me => me.UserId == mentee.MenteeId);

                foreach (var menteeAvailability in matchingAvailabilities)
                {
                    var matchingMentorAvailabilities = mentorAvailabilities
                        .Where(ma => menteeAvailability.StartTimePst.Hour <= ma.StartTimePst.Hour && menteeAvailability.EndTimePst.Hour >= ma.EndTimePst.Hour);

                    foreach (var matchingMentorAvailability in matchingMentorAvailabilities)
                    {
                        var matchingMentor = mentors.FirstOrDefault(m => m.SeattleUId == matchingMentorAvailability.UserId);
                        var potentialMatch = new PotentialMatch
                        {
                            DayOfTheWeek = menteeAvailability.DayOfTheWeek,
                            Period = menteeAvailability.PeriodName,
                            TeacherName = menteeAvailability.TeacherName,
                            SuggestedMentor = matchingMentor.FirstName + " " + matchingMentor.LastName,
                            MenteeId = mentee.MenteeId,
                            MentorId = matchingMentor.SeattleUId
                        };

                        lb_Matches.Items.Add(potentialMatch);
                    }
                }
            }
        }

        private void cb_Quarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedQuarter = (QuarterEntity)cb_Quarter.SelectedItem;

            ReloadMatches(selectedQuarter.ToString());

        }

        private void lb_Matches_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Details.Text = String.Empty;
        }

        private void lb_Matches_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var index = e.Index;
            var itemChecked = e.NewValue;


        }
    }
}
