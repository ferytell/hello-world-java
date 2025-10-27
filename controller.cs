public class GridController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public JsonResult GetParents()
    {
        var parents = new List<ParentModel>
        {
            new ParentModel { Id = 1, Name = "Parent 1" },
            new ParentModel { Id = 2, Name = "Parent 2" },
            new ParentModel { Id = 3, Name = "Parent 3" }
        };
        return Json(parents, JsonRequestBehavior.AllowGet);
    }

    public JsonResult GetChildren(int parentId)
    {
        var children = new List<ChildModel>();
        
        // Simulate data - replace with your actual data source
        if (parentId == 1)
        {
            children = new List<ChildModel>
            {
                new ChildModel { Id = 1, Name = "Child 1-1", ParentId = 1 },
                new ChildModel { Id = 2, Name = "Child 1-2", ParentId = 1 }
            };
        }
        else if (parentId == 2)
        {
            children = new List<ChildModel>
            {
                new ChildModel { Id = 3, Name = "Child 2-1", ParentId = 2 },
                new ChildModel { Id = 4, Name = "Child 2-2", ParentId = 2 }
            };
        }
        else if (parentId == 3)
        {
            children = new List<ChildModel>
            {
                new ChildModel { Id = 5, Name = "Child 3-1", ParentId = 3 },
                new ChildModel { Id = 6, Name = "Child 3-2", ParentId = 3 }
            };
        }
        
        return Json(children, JsonRequestBehavior.AllowGet);
    }

    public JsonResult GetGridData()
    {
        var data = new List<GridModel>
        {
            new GridModel { Id = 1, ParentId = 1, ChildId = 1, Data3 = "Data 3A" },
            new GridModel { Id = 2, ParentId = 2, ChildId = 3, Data3 = "Data 3B" }
        };
        return Json(data, JsonRequestBehavior.AllowGet);
    }
}
