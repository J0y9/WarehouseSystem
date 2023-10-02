using WarehouseSystem;

var warehouse = new Warehouse();
warehouse.AddItem(new Item(1,"PC",999,10));
warehouse.AddItem(new Item(2,"Laptop",200,1));
warehouse.AddItem(new Item(3,"Iphone",10000,2));
warehouse.ShowItems();
warehouse.RemoveItem(3);
Console.WriteLine();
warehouse.ShowItems();
warehouse.Clear();

Console.WriteLine();
warehouse.ShowItems();