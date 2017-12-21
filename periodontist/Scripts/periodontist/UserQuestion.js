pd = {} || ""

pd.question = {
  init: function () {

    $(".btnSendQuestion").on("click", function (e) {
      e.preventDefault;
      pd.question.sendQuestion();
    })
  }
  , sendQuestion: function () {
    var queryUrl = "Home/SendQuestion";
    $.ajax({
      url: queryUrl,
      type: "POST",
      dataType: "json",
      data: {
        Name: "vasia"
        , Email: "gg@rr.ru"
        , QuestionText:"bla bla"
      },
      success: function (data) {
        console.log(data);
      }
    });
  }
}