using System;
using System.Collections.Generic;

namespace BL.models;

public partial class Room
{
    public int RoomId { get; set; }

    public int NumOfSeats { get; set; }

    public int NumOfComputers { get; set; }

    public bool IsProjector { get; set; }

    public bool IsBoard { get; set; }

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
}
