using roastreview.models;

namespace roastreview.data;

public static class StockList
{

    public static List<StockItem> Coffees = new List<StockItem> {
        new StockItem() { Id=1, Name="Macchiato", Description="Gets you out of bed in the morning" },
        new StockItem() { Id=2, Name="Red Eye", Description="Gets you out of bed in the morning" },
        new StockItem() { Id=3, Name="Flat White", Description="Gets you out of bed in the morning" },
        new StockItem() { Id=4, Name="Lungo", Description="Gets you out of bed in the morning" },
        new StockItem() { Id=5, Name="Latte", Description="Gets you out of bed in the morning" }
    };
}
