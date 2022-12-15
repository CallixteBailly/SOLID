public interface IOrder
{
    void ProcessOrder();
}

public class DigitalProduct : IOrder
{
    public void ProcessOrder()
    {
        // ...
    }
}

public class PhysicalProduct : IOrder
{
    public void ProcessOrder()
    {
        // ...
    }
}

public class ServiceOrder : IOrder
{
    public void ProcessOrder()
    {
        // ...
    }
}

public class OrderProcessor
{
    private readonly IOrder _order;

    public OrderProcessor(IOrder order)
    {
        _order = order;
    }

    public void ProcessOrder()
    {
        _order.ProcessOrder();
    }
}

public class Client
{
    static void Main(string[] args)
    {
        IOrder digitalOrder = new DigitalProduct();
        OrderProcessor digitalProcessor = new OrderProcessor(digitalOrder);
        digitalProcessor.ProcessOrder();

        IOrder physicalOrder = new PhysicalProduct();
        OrderProcessor physicalProcessor = new OrderProcessor(physicalOrder);
        physicalProcessor.ProcessOrder();

        IOrder serviceOrder = new ServiceOrder();
        OrderProcessor serviceProcessor = new OrderProcessor(serviceOrder);
        serviceProcessor.ProcessOrder();
    }
}
