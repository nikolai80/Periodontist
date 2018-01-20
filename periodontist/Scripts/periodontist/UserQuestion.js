pd = {} || ""

pd.question = {
  init: function () {

    var questionForm = new Vue({
      el: '#questionForm'
      , methods: {
      }
    });


    $(".btnSendQuestion").on("click", function (e) {
      e.preventDefault;
      var name, email, theme, questionText;
      name = $(".questionForm__name").val();
      email = $(".questionForm__email").val();
      theme = $(".questionForm__theme").val();
      questionText = $(".questionForm__text").val() || "";
      console.log(name, email, theme, questionText);

      pd.question.sendQuestion(name, email, theme, questionText);
    });

    $('.inputFileUpload').on('change', function (e) { pd.question.uploadFile() });
  }
  , sendQuestion: function (name, email, theme, questionText) {
    var queryUrl = "Home/SendQuestion";
    $.ajax({
      url: queryUrl,
      type: "POST",
      dataType: "json",
      data: {
        Name: name
        , Email: email
        , Theme: theme
        , QuestionText: questionText
      },
      success: function (data) {
        if (data) {
        };
      }
    });
  }
  , uploadFile: function () {
    var queryUrl = "Home/Upload";

    var files = document.getElementById("uploadFiles").files;
    //var myID = 3; //uncomment this to make sure the ajax URL works
    if (files.length > 0) {
      if (window.FormData !== undefined) {
        var data = new FormData();
        for (var x = 0; x < files.length; x++) {
          data.append("file" + x, files[x]);
        }

        $.ajax({
          type: "POST",
          url: queryUrl,
          contentType: false,
          processData: false,
          data: data,
          success: function (result) {

            console.log(result);
          },
          error: function (xhr, status, p3, p4) {
            var err = "Error " + " " + status + " " + p3 + " " + p4;
            if (xhr.responseText && xhr.responseText[0] == "{")
              err = JSON.parse(xhr.responseText).Message;
            console.log(err);
          }
        });
      } else {
        alert("This browser doesn't support HTML5 file uploads!");
      }
    }
  }
}