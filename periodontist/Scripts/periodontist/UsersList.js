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
            , data: {
                title: usersList.config.title
                , usersData: []
            }
            , created: function () {
                this.getList();
            }
            , methods: {
                getList: function () {
                    axios.post('/Manage/GetUsersList')
                        .then(function (response) {
                            console.log(JSON.parse(JSON.stringify(response.data.result)));
                            users.usersData = response.data.result;
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                },
                addUserRole: function (userId,roleId) {
                    axios.post('/Manage/AddUserRole')
                        .then(function (response) {


                        })
                        .catch(function (error) {
                            console.log(error);
                        });
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