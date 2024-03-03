using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace proba.Models;

public class Reservation
{
    [Key]
    public required int ID { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public User? User { get; set; }
    public int UID { get; set; }
    public MyObject? Object { get; set; }
    public int ObjID { get; set; }

}
