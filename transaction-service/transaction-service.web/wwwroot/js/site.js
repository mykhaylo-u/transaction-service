﻿//This script will show file name on selected form

$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(".custom-file-label").addClass("selected").html(fileName);
});

$(".custom-file-input").on("click", function () {

    $(".text-success").text('');
    $(".field-validation-error").text('');
});
