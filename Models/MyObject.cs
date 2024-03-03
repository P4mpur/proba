using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace proba.Models;

public class MyObject
{
    [Key]
    public required int ID { get; set; }
    public required string? Naziv { get; set; }

    public required string? Prezime { get; set; }

    public required string? Adresa { get; set; }

    public User? Landlord { get; set; }

    [ForeignKey("ObjectID")]
    public List<Reservation>? Reservations { get; set; }
    [ForeignKey("ObjectID")]
    public List<Feedback>? Feedbacks { get; set; }

}
