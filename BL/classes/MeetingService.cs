using BL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    internal class MeetingService
    {
        //הפונקציה מקבלת ת.ז. של ראש הצוות זמן התחלה וזמן סיום וקובעת פגישה
        //מחזירה trueאם הצליחה...
        public bool ScheduleMeeting(string id,DateTime start,DateTime end)
        {
            return true;
        }
        public bool Addmeeting(Meeting meeting) 
        { 
            return true;
        }

        //מחזירה את כל הפגישות של עובד מסוים שעוד לא התבצעו
       public List<Meeting> GetAllMeeting(string id)
        {
            List <Meeting> meetings= getMeetings(id);
            List<Meeting> meetingReturn=new List<Meeting> ();
            for (int i = 0;i< meetings.Count; i++)
            {
                if (meetings[i].Date < DateTime.Now)
                {
                    meetingReturn.Add(meetings[i]);
                }
               
            }
            return meetingReturn;
        }

    }
}
