﻿setInterval(function () {
    var macId = $("#hdn_macId").val();
    var url = "http://10.20.10.65:8010";

    $.ajax({
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        url: url + "/Report/UpdateLoginDetails?machineId=" + macId,
        success: function (data) {
            console.log(data);
        }
    });
}, 2500);