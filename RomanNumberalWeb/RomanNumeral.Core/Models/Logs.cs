using System.ComponentModel.DataAnnotations;

namespace RomanNumberalWeb.Models;

public class Logs 
{
    
    public int Id { get; set; }
    
    [Display(Name = "Time Created")]
    public DateTime TimeCreated { get; set; }
    
    public string Input { get; set; }
    public string Output { get; set; }
}