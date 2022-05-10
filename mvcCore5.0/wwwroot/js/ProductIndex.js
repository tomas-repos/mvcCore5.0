
$(document).ready(function () {
    $("#btnModalPdcto").click(function () {
        var ddlShippers = $("#shippers");

        ddlShippers.empty().append('<option selected="selected" value="0" disabled="disabled">loading...</option> ');
        $.ajax({
            type: "GET",
            url: "Product/LoadLists",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log("sucess" + data);
                
                
                //var s = '<option value="-1">Please Select a shipper</option>';
                //for (var i = 0; i < data.ShipperId.length; i++) {
                //    s += '<option value="' + data[i].ShipperId + '">' + data[i].CompanyName + '</option>';
                //}
                //$("#ddlShippers").html(s);
                //ddlShippers.empty().append('<option selected="selected" value="0">Please select</option>');
                
            }, error: function (xhr, ajaxOptions, thrownError) {
                console.log(xhr.status+"+");
                console.log(thrownError);
            }
        });


        $('#modalProducto').modal('show');
    });
  

    $("#btnSaveProduct").click(function () {
        console.log("btn save q weaaa");
        

    });
    
    $("#btnCancel").click(function () {
        $('#modalProducto').modal('hide');
    });

});

    

