using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;
[Table("CompanyNTS999")]
public class CompanyNTS999
{
    [Key, StringLength(20), Display(Name = "ID")]
    public string CompanyID {get; set;}
    [Required, StringLength(50), Display(Name = "Tên")]
    public string CompanyName {get; set;}
}