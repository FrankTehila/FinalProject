using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    interface IMeetingManager
    {
        void AddMeeting(Meeting meeting);
        void DeleteMeeting(string meetingId);
        void UpdateMeeting(Meeting meeting);
        Meeting GetTheNextMeeting();
        public List<Meeting> GetAllFutureMeetings();
        List<Meeting> GetAllPastMeetings();
    }
}
