namespace TimelySkills.Core.DTOs;

public class OrderDTO
{
    public int OrderId { get; set; }
    
    public Sender Sender { get; set; }
    
    public Receiver Receiver { get; set; }
    
    public decimal Weight { get; set; }
    
    public DateTime DateOfDispatch { get; set; }
}

public class Receiver
{
    public string ReceiverFirstName { get; set; }
    
    public string ReceiverLastName { get; set; }

    public string ReceiverPatronymic { get; set; }
    
    public string ReceiverCity { get; set; }
    
    public string ReceiverAddress { get; set; }
}

public class Sender
{
    public string SenderFirstName { get; set; }
    
    public string SenderLastName { get; set; }
    
    public string SenderPatronymic { get; set; }
    
    public string SenderCity { get; set; }
    
    public string SenderAddress { get; set; }
}