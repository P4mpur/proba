using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace proba.Models;

public class User
{
    [Key]
    public required int ID { get; set; }
    [Required]
    public string? Ime { get; set; }
    [Required]
    public string? Prezime { get; set; }

    public List<MyObject>? Objects { get; set; }

    [ForeignKey("UserID")]
    public List<Reservation>? Reservations { get; set; }

    [ForeignKey("UserID")]
    public List<Feedback>? Feedbacks { get; set; }

}
