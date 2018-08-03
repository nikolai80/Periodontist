pd = {} || ""

pd.usersList = {
    init: function () {

        var usersList = new Vue({
            el: '#usersList'
            , methods: {
            }
            , data: {
                title: 'Список зарегистрированных пользователей'
                //, usersData: this.getUsersData()
            }
        });
        this.getUsersData();

    }

    , getUsersData: function () {

        $.ajax({
            url: "Manage/GetUsersList"
            , type: "POST"
            , dataType: "json"
            , success: function (data) {
                console.info(data);
                if (data) {
                    console.info(data);
                }
            }
        });

    }
}