using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data;

public partial class Contact : BaseEntity
{
    public string Name { get; set; } = null!;

    public decimal Phonenumber { get; set; }

    public int Id { get; set; }
}
