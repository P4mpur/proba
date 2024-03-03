using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace proba.Models;

public class Feedback
{
    [Key]
    public required int ID { get; set; }

    public float Ocena { get; set; }

    public string? Opis { get; set; }

    public User? User { get; set; }
    public int UID { get; set; }


    public MyObject? Object { get; set; }
    public int ObjID { get; set; }
}
