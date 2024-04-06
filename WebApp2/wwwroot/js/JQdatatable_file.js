

$(document).ready(function () {
    GetCustomer();
});

//success: function (response) {debugger}
function GetCustomer(){
    $.ajax({
        url: '/Excel/GetCustomerList',
        type: 'Get',
        dataType: 'json',
        success: OnSuccess  
        
      })
    }

function OnSuccess(response) {
    $('#dataTableData').DataTable({
        bProcessing: true,
        bLengthChange: true,
        lengthMenu: [[5, 10, 25, -1], [5, 10, 25, "All"]],
        bfilter: true,
        bSort: true,
        bPaginate: true,
        data: response,
        columns: [
            {
                data: 'Id',
                render: function (data, type, row, meta) {
                    return row.id
                }
            },
            {
                data: 'CustomerCode',
                render: function (data, type, row, meta) {
                    return row.customerCode
                }
            },
            {
                data: 'FirstName',
                render: function (data, type, row, meta) {
                    return row.firstName
                }
            },
            {
                data: 'LastName',
                render: function (data, type, row, meta) {
                    return row.lastName
                }
            },
            {
                data: 'Gender',
                render: function (data, type, row, meta) {
                    return row.gender
                }
            },
            {
                data: 'Country',
                render: function (data, type, row, meta) {
                    return row.country
                }
            },
            {
                data: 'Age',
                render: function (data, type, row, meta) {
                    return row.age
                }
            }
            ,
            {
                data: 'Id',"width":"50px",
                render: function (data, type, row, meta) {
                    return '<button type="button" id="' + row.id +'" class="btn btn-primary btnEdit"><i class="fa fa-edit"></i></button>'
                }
            }

        ]

    });

}


$(document).on("click",".btnEdit",function () {
    var id = $(this).attr("id");
    alert(id);
});


//row click 


