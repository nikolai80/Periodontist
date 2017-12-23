pd = {} || ""

pd.question = {
  init: function () {

    $(".btnSendQuestion").on("click", function (e) {
      e.preventDefault;
      var name, email, theme, questionText;
      name = $(".questionForm__name").val();
      email = $(".questionForm__email").val();
      theme = $(".questionForm__theme").val();
      questionText = $(".questionForm__text").val() || "";
      console.log(name, email, theme, questionText);

      pd.question.sendQuestion(name, email, theme, questionText);
    })
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
}