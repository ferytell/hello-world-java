//additional js for error handling
function error_handler(e) {
    if (e.errors) {
        var message = "Errors:\n";
        $.each(e.errors, function (key, value) {
            if ('errors' in value) {
                $.each(value.errors, function () {
                    message += this + "\n";
                });
            }
        });
        alert(message);
    }
}

// Refresh child dropdowns when grid is bound
$(document).ready(function() {
    $("#grid").data("kendoGrid").bind("dataBound", function() {
        var grid = this;
        grid.tbody.find("tr").each(function() {
            var dataItem = grid.dataItem(this);
            if (dataItem && dataItem.ParentId) {
                var childDropdown = $(this).find("[data-role=dropdownlist]").eq(1).data("kendoDropDownList");
                if (childDropdown) {
                    childDropdown.dataSource.read({ parentId: dataItem.ParentId });
                }
            }
        });
    });
});
