using System.Collections.Generic;
public abstract class Article
{
    public abstract decimal GetPrice();
}

public class PhysicalArticle : Article
{
    public decimal Price { get; set; }
    public decimal ShippingCost { get; set; }

    public override decimal GetPrice()
    {
        return Price + ShippingCost;
    }
}

public class DigitalArticle : Article
{
    public decimal Price { get; set; }

    public override decimal GetPrice()
    {
        return Price;
    }
}

public class MarketplaceArticle : Article
{
    public decimal Price { get; set; }
    public decimal Commission { get; set; }

    public override decimal GetPrice()
    {
        return Price + Commission;
    }
}

public class Order
{
    private List<Article> _articles = new List<Article>();

    public void AddArticle(Article article)
    {
        _articles.Add(article);
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var article in _articles)
        {
            totalPrice += article.GetPrice();
        }
        return totalPrice;
    }
}
