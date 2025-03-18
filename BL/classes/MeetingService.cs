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
        //public bool AddMeating(Meating meating) 
        //{ 
        //    return true;
        //}

        //מחזירה את כל הפגישות של עובד מסוים שעוד לא התבצעו
       //public List<Meating> GetAllMeeting(string id)
       // {
       //     List < Meating > meatings= getMeatings(id);
       //     List<Meating> meatingReturn=new List<Meating> ();
       //     for (int i = 0;i< meatings.Count; i++)
       //     {
       //         if (meatings[i].start < DateTime.Now)
       //         {
       //             meatingReturn.Add(meatings[i]);
       //         }
               
       //     }
       //     return meatingReturn;
       // }

    }
}
