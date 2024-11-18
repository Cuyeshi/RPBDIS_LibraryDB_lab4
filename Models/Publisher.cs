using RPBDIS_lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPBDIS_lab4.Models;

public partial class Publisher
{
    [Key]
    public int PublisherId { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
