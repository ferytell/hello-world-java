public class ParentModel
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class ChildModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParentId { get; set; }
}

public class GridModel
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? ChildId { get; set; }
    public string Data3 { get; set; }
}
