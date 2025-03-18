using System;
using System.Collections.Generic;

namespace BL.models;

public partial class Employee1
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int LeaderId { get; set; }
}
