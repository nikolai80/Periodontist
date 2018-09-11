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
                ,queryResponse
            }
            , created: function () {
                this.getList();
            }
            , methods: {
                getList: function () {
                    axios.post('/Role/GetRoles')
                        .then(function (response) {
                            console.log(JSON.parse(JSON.stringify(response.data.result)));
                            rolesList.rolesListData = response.data.result;
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                }
                , newRole: function () {

                    axios.post('/Role/Create', new { Name: "name", Description: "description" })
                        .then(function (response) {
                            rolesList.queryResponse = response.data.result;
                        }).catch(function (error) {
                            console.log(error);
                        });
                }
            }

        });
    }

    , addNewRole: function () {
        console.info("add role function");
        var addRole = $.ajax({
            url: "/Role/Create"
            , type: "POST"
            , dataType: "json"
            , success: function (data) {
                if (data) {
                    console.info(JSON.parse(JSON.stringify(data.result)));
                }
                return JSON.parse(JSON.stringify(data.result));
            }
        });


    }
};
$(document).ready(
    function () {
        role.init();
    }
);