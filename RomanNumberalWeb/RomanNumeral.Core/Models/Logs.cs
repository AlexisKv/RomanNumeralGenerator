using System.ComponentModel.DataAnnotations;

namespace RomanNumeral.Core.Models;

public class Logs : Entity
{
    [Key]
    public int Id { get; set; }
    
    [Display(Name = "Time Created")]
    public DateTime TimeCreated { get; set; }
    
    public string Input { get; set; }
    public string Output { get; set; }
}