namespace TimelySkills.Core.Entities;

public class Order
{
    public int OrderId { get; set; }
    
    public string SenderFirstName { get; set; }
    
    public string SenderLastName { get; set; }
    
    public string SenderPatronymic { get; set; }

    public string SenderCity { get; set; }
    
    public string SenderAddress { get; set; }
    
    public string ReceiverFirstName { get; set; }
    
    public string ReceiverLastName { get; set; }

    public string ReceiverPatronymic { get; set; }
    
    public string ReceiverCity { get; set; }
    
    public string ReceiverAddress { get; set; }
    
    public decimal Weight { get; set; }
    
    public DateTime DateOfDispatch { get; set; }
}