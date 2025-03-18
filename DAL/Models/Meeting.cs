using System;
using System.Collections.Generic;

namespace BL.models;

public partial class Meeting
{
    public int MeetId { get; set; }

    public int NumOfRoom { get; set; }

    public DateTime Date { get; set; }

    public virtual Room NumOfRoomNavigation { get; set; } = null!;
}
