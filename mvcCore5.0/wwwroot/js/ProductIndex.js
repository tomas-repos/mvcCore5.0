
$(document).ready(function () {
    $("#btnModalPdcto").click(function () {
        var ddlShippers = $("#shippers");

        ddlShippers.empty().append('<option selected="selected" value="0" disabled="disabled">loading...</option> ');
        $.ajax({
            type: "GET",
            url: "Product/LoadShippers",
            //data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log("sucess");
                console.log("response "+response);
                console.log("response.d"+response.data);
                ddlShippers.empty().append('<option selected="selected" value="0">Please select</option>');
                var s = '<option value="-1">Please Select a wea</option>';
                for (var i = 0; i < response.length; i++) {
                    s += '<option value="' + response[i].ShipperId + '">' + response[i].CompanyName + '</option>';
                }
                $("#shippers").html(s);
                //$("#departmentsDropdown").html(s);
                //$.each(data.d, function () {
                    
                //    ddlShippers.append($("<option     />").val(this.KeyName).text(this.ValueName));
                //});
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

    

