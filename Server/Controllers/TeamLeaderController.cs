using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamLeaderController : ControllerBase
    {
        ITeamLeader teamLeader;

        public TeamLeaderController(ITeamLeader teamLeader)
        {

            this.teamLeader = teamLeader;

        }

        [HttpGet]
        // מחזירה את כל הישיבות צוות שיש לראש צוות/לעוב מסוים לפי ID
        public IActionResult GetAllStaffMeetings(string id)
        {
            // פונקציה שמחזירה רשימה של פגישות
            return Ok() ;
        }
        [HttpGet]
        //פונקציה מקבלת ת.ז. ומחזירה את הפגישה הקרובה שיש לעובד המסוים
        public IActionResult GetLastStaffMeeting(string id) 
        { 
            return Ok() ;
        }
        [HttpPost]
        //הפונקציה מקבלת ת.ז.של עובד ובודקת אם הוא ראש צוות היא מוסיפה את הפגישה שלו ,אחרת מחזירה שגיאה
        public IActionResult AddNewStaffMeeting(string id)
        {

            bool b=true;//פונקציה שמוסיפה פגישה 
            if (b)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteStaffMeeting(int id)
        {
            if(/* פונקציה שמוחקת פגישה*/ id == 0)
            {
                return Ok();
            }
            return BadRequest();
            
        }

    }
}
