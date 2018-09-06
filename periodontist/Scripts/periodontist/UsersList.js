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
            }
            , data: {
                title: usersList.config.title
                , usersData: this.getUsersData()
            }
        });

    }

    , getUsersData: function () {

        $.ajax({
            url: "/Manage/GetUsersList"
            , type: "POST"
            , dataType: "json"
            , success: function (data) {
                if (data) {
                    console.info(data);
                    
                }

            }
        });

    }
};
$(document).ready(
    function () {
        usersList.init();
    }
);