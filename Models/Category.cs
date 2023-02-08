namespace CocoaAni.QBitTorrentApis.Models;

public class Category
{
    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Category()
    {
        Id = default!;
        Name = default!;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}