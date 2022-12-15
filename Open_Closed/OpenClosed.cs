using System.Collections.Generic;
public interface IOrder
{
    int OrderId { get; set; }
    decimal CalculateOrderTotal();
}

public class Order : IOrder
{
    public int OrderId { get; set; }
    public decimal CalculateOrderTotal()
    {
        return 0;
    }
}

public class SpecialOrder : IOrder
{
    public int OrderId { get; set; }
    public decimal Discount { get; set; }
    public decimal CalculateOrderTotal()
    {
        decimal total = 0;
        total -= Discount;
        return total;
    }
}
public class OrderCalculator
{
    public int ComputeAllOrders(IEnumerable<IOrder> orders)
    {
        int result = 0;
        foreach (var item in orders)
        {
            result += item.CalculateOrderTotal();              
        }
        return result;
    }
}
