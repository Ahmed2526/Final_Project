#nullable disable
using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Location
{
    public int Id { get; set; }

    public string Governate { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string PostalCode { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}