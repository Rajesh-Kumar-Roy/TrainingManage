


$(document).ready(function() {
    $.ajax({
        url: "/student/GetAllDepartmentJsonResult",
        success: function(response) {
            var departments = response;
            $.each(departments,
                function(key, department) {
                    var option = "<option value='" + department.id + "'>" + department.name + "</option>";
                    $("#DepartmentId").append(option);


                });
        }


    });


});



$('#DepartmentId').change(function () {
    var departmentDD = $('#DepartmentId');
    var departmentId = departmentDD.val();

    //ajax call to https://localhost:44394/trainee/getbydepartmentPartial

    var jsonData = { departmentId: departmentId }


    $.ajax({
        url: "/student/GetByDepartmentPartial",
        data: jsonData,
        success: function (response) {
            $('#div_studentList').html(response);
        }


    });



});