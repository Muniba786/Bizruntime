
function fnInsert() {
    var FirstName = $("#Fname").val();
    var LastName = $("#Lname").val();
    var MobNo = $("#MobNo").val();
    var Address = $("#Address").val();


    $.ajax({
        type: "POST",
        url: "Home/InsertFields",
        datatype: "json",
        contentType: "application/json: charset-utf-8",
        data: JSON.stringify({ FirstName: FirstName, LastName: LastName, MobNo: MobNo, Address: Address }),
        success: function (json) {
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });
}

$(document).ready(function () {
    ViewData();
    $("#update").hide;

    function ViewData() {

        $.ajax({
            type: "POST",
            url: "Home/ViewData/",
            datatype: "json",
            contentType: "application/json: charset-utf-8",
            data: JSON.stringify({}),
            success: function (json1) {
                debugger
                var tableload = json1.html;
                var dataset = eval("[" + tableload + "]");
                $('#ViewValues').DataTable({
                    ordering: false,
                    data: dataset,
                    columns: [
                        { title: "ID" },
                        { title: "First Name" },
                        { title: "Last Name" },
                        { title: "Mobile Number" },
                        { title: "Address" },
                        { title: "Action" },
                    ]
                });
            },
            failure: function (erMsg) {
                alert(errMsg);
            }

        });

    }
});

function fnDelete(id) {
    $.ajax({
        type: "POST",
        url: "Home/DeleteData/",
        datatype: "json",
        contentType: "application/json: charset-utf-8",
        data: JSON.stringify({ id: id }),
        success: function (json) {

            window.location.replace("/Home/Index");
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });
}

function fnEdit(id) {
    $.ajax({
        type: "POST",
        url: 'Home/EditData/',
        datatype: "json",
        contentType: "application/json: charset-utf-8",
        data: JSON.stringify({ id: id }),
        success: function (json) {
            var arrval = json.htmlValues;

            $("#Fname").val(arrval[0]);
            $("#Lname").val(arrval[1]);
            $("#MobNo").val(arrval[2]);
            $("#Address").val(arrval[3]);
            $("#id").val(arrval[4]);

            $("#create").hide();
            $("#update").show();

           
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });

}

function fnUpdate() {
    var FirstName = $("#Fname").val();
    var LastName = $("#Lname").val();
    var MobNo = $("#MobNo").val();
    var Address = $("#Address").val();
    var id = $("#id").val();


    $.ajax({
        type: "POST",
        url: "Home/UpdateFields",
        datatype: "json",
        contentType: "application/json: charset-utf-8",
        data: JSON.stringify({ FirstName: FirstName, LastName: LastName, MobNo: MobNo, Address: Address, id: id}),
        success: function (json) {
            ViewData();

            window.location.replace("/Home/Index");
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });
}