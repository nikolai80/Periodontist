var usersList = usersList || {};

usersList = {
    config: {
        title:"Список зарегистрированных пользователей"
    }
    ,init: function (config) {
        if (config && typeof(config) === "object") {
            $.extend(usersList.config, config);
            
        }

        var users = new Vue({
            el: '#usersList'
            , data: {
                title: usersList.config.title
                , usersData: []
                , rolesData: []
                ,userId:-1
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
                addUserRole: function (userId) {
                    users.userId = userId;
                    axios.post('/Role/GetRoles')
                        .then(function (response) {
                            users.rolesData = response.data.result;
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                    
                    $("#addUserRoleModal").modal();
                }
                , saveUserRole: function (userId) {

                    var roleId = $("#selectRole").val();
                    axios.post('/Manage/AddUserRole', { UserId: userId, RoleId:roleId })
                        .then(function (response) {
                            console.debug(response.data.result);
                            $("#addUserRoleModal").modal("hide");
                            location.reload();
                        })
                        .catch(function (error) {
                            console.log(error);
                        });}
            }
            
        });
    }
};
$(document).ready(
    function () {
        usersList.init();
    }
);