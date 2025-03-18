using System;
using System.Collections.Generic;

namespace BL.models;

public partial class TeamLeader
{
    public int Id { get; set; }

    public int? NumOfWorkers { get; set; }

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;
}
