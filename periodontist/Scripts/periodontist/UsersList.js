var usersList = usersList || {};

usersList = {
    config: {
        title:"Список зарегистрированных пользователей"
    }
    ,init: function (config) {
        if (config && typeof(config) == "object") {
            $.extend(usersList.config, config);
            
        }

        var users = new Vue({
            el: '#usersList'
            , methods: {
                getList() {
                    this.usersData=[{ "Email": "ggg@hh.ru" }];
                    //$.ajax({
                    //    url: "/Manage/GetUsersList"
                    //    , type: "POST"
                    //    , dataType: "json"
                    //    , success: function (data) {
                    //        if (data) {
                    //            console.info(JSON.parse(JSON.stringify(data.result)));
                    //        }
                    //        this.userData= JSON.parse(JSON.stringify(data.result));
                    //    }
                    //});
                }
            }
            , data: {
                title: usersList.config.title
                , usersData: []
            }
        });
    }

    , getUsersData: function () {
        
      var list=  $.ajax({
            url: "/Manage/GetUsersList"
            , type: "POST"
            , dataType: "json"
            , success: function (data) {
                if (data) {
                    console.info(JSON.parse(JSON.stringify(data.result)));
                }
                return JSON.parse(JSON.stringify(data.result));
            }
        });

      return list;

    }
};
$(document).ready(
    function () {
        usersList.init();
    }
);