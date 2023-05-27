using System.ComponentModel.DataAnnotations;

namespace TimelySkills.Web.Models;

public class OrderViewModel
{
    [Required]
    [Display(Name = "ФИО отправителя")]
    [StringLength(50)]
    public string SenderFIO { get; set; }

    [Required]
    [Display(Name = "Город отправителя")]
    [StringLength(50)]
    public string SenderCity { get; set; }
    
    [Required]
    [Display(Name = "Адрес отправителя")]
    [StringLength(50)]
    public string SenderAddress { get; set; }
    
    [Required]
    [Display(Name = "ФИО получателя")]
    [StringLength(50)]
    public string ReceiverFIO{ get; set; }

    [Required]
    [Display(Name = "Город получателя")]
    [StringLength(50)]
    public string ReceiverCity { get; set; }
    
    [Required]
    [Display(Name = "Адрес получателя")]
    [StringLength(50)]
    public string ReceiverAddress { get; set; }
    
    [Required]
    [Display(Name = "Вес")]
    public decimal Weight { get; set; }
    
    [Required]
    [Display(Name = "Дата отправки")]
    public DateTime DateOfDispatch { get; set; }
}