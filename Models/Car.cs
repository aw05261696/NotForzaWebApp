using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotForza.Models;

public class Car
{

    public int CarID {get; set; }
    public string? CarName {get; set; }
    public string? CarModel {get; set; }
    public int CarYear {get; set; }
    public string? CarGrade {get; set; }
    public int CarCost {get; set; }
    public string CarDescription {get; set; } = string.Empty;
    public string CarPicURL {get; set; } = string.Empty;

}

