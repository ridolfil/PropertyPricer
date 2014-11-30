
$(document).ready(function () {
    $("#lStartDate, #lEndDate").datepicker({
        changeMonth: true,
        changeYear: true
    });

    $("#addBtn").click(function () {
        $("#addLeaseForm").slideToggle();
    });
    

});