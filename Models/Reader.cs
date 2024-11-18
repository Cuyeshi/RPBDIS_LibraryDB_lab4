﻿using RPBDIS_lab4.Models;
using System;
using System.Collections.Generic;

namespace RPBDIS_lab4.Models;

public partial class Reader
{
    public int ReaderId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Gender { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string Passport { get; set; } = null!;

    public virtual ICollection<LoanedBook> LoanedBooks { get; set; } = new List<LoanedBook>();
}
