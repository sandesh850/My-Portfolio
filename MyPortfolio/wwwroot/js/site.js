
$(document).ready(function () {

    // opening file explorer
    $("#btnBrows").on("click", function () {
        $("#fileInput").trigger("click");
    });

    $("#fileInput").on("change", function (event) {

        var file = event.target.files[0];

        if (file)
        {
            var filereader = new FileReader;

            filereader.onload = function (e) {

                $("#imgPreview").attr("src", e.target.result);

               
            }

            filereader.readAsDataURL(file);

        }
        else {
            alert("No file selected");
        }

    });
   
});
