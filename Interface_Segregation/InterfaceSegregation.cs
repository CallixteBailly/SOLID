public interface IOrder
{
    void PlaceOrder();
    void TrackOrder();
    void CancelOrder();
}

public interface IHomeDelivery
{
    void SetDeliveryAddress(string address);
}

public interface IStorePickup
{
    void SetPickupStore(string store);
}

public interface IRelayPoint
{
    void SetRelayPoint(string point);
}

public class Order : IOrder, IHomeDelivery, IStorePickup, IRelayPoint
{
    public void PlaceOrder()
    {
        // ...
    }

    public void TrackOrder()
    {
        // ...
    }

    public void CancelOrder()
    {
        // ...
    }

    public void SetDeliveryAddress(string address)
    {
        // ...
    }

    public void SetPickupStore(string store)
    {
        // ...
    }

    public void SetRelayPoint(string point)
    {
        // ...
    }
}
public class ProOrder : IOrder, IHomeDelivery, IRelayPoint
{
    public void PlaceOrder()
    {
        // ...
    }

    public void TrackOrder()
    {
        // ...
    }

    public void CancelOrder()
    {
        // ...
    }

    public void SetDeliveryAddress(string address)
    {
        // ...
    }

    public void SetRelayPoint(string point)
    {
        // ...
    }
}
