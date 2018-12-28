var userData = userData || {};

userData = {
    config: {
        title: "Личный кабинет пользователя"
    }
    , init: function (config) {
        if (config && typeof (config) === "object") {
            $.extend(usersList.config, config);

        }
        this.getVueObj(this.config);
    }
    , getVueObj: function (config) {
        var user = new Vue({
            el: '#userData',
            data: {
                title: config.title
                
            }
        }
        );

    }
};
$(document).ready(
    function () {
        userData.init();
    }
);