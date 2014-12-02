
$(document).ready(function () {
    $("#lStartDate, #lEndDate").datepicker({
        changeMonth: true,
        changeYear: true
    });

    $("#addBtn").click(function () {
        $("#addLeaseForm").slideToggle();
    });
    


    $("#leaseTable tr:gt(0)").click(function (e) {
        $("#leaseTable tr:gt(0)").removeClass("active")
        var row = $(this);
        row.addClass("active");
        var id = row.children("td:first").text();
        $("#cashflowColumn").load("/Lease/ShowCashflows", "id=" + id);
    });



});