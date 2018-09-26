var role = role || {};

role = {
    config: {
        title: "Редактор ролей"
    }
    , init: function (config) {
        if (config && typeof (config) === "object") {
            $.extend(role.config, config);

        }

        var rolesList = new Vue({
            el: '#roleEditor'
            , data: {
                title: role.config.title
                , rolesListData: []
            }
            , created: function () {
                this.getList();
            }
            , methods: {
                getList: function () {
                    axios.post('/Role/GetRoles')
                        .then(function (response) {
                            rolesList.rolesListData = response.data.result;
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                }
                , newRole: function () {
                    $("#addNewRole").modal();
                    
                }
                , addNewRole: function () {

                    var roleName = $(".addNewRole_name").val();
                    var roleDescription = $(".addNewRole_Description").val();

                    axios.post('/Role/Create', { Name: roleName, Description: roleDescription })
                        .then(function (response) {
                            $("#addNewRole").modal('hide');
                            rolesList.getList();
                        }).catch(function (error) {
                            console.log(error);
                        });
                }
            }

        });
    }
   
};
$(document).ready(
    function () {
        role.init();
    }
);