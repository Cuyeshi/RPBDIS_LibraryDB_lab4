﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace RPBDIS_lab4.Models
{
    public class LoanedBook
    {
        [Key]
        public int LoanId { get; set; }

        public int? BookId { get; set; }

        public int? ReaderId { get; set; }

        public DateOnly LoanDate { get; set; }

        public DateOnly? ReturnDate { get; set; }

        public bool Returned { get; set; }

        public string? Employee { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Book? Book { get; set; }

        public virtual Employee? EmployeeNavigation { get; set; }

        public virtual Reader? Reader { get; set; }
    }

}
