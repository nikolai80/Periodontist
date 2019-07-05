var listArticles = new Vue({
    el: '#listArticles',
    data: {
        articles: [],
        countSumbols: 200
    },
    mounted: function () {
        this.getAllArticles();
    },
    methods: {
        getAllArticles: function () {
            axios.post("content/GetAllArticles").then(function (response) {
                if (response.data.result) {
                    listArticles.articles = response.data.data;
                }
            });

        },
        updateArticle: function (articleId) {
            location.href="content/UpdateArticle?ID="+articleId;
        },
        removeArticle: function (event) {
            alert("Удалить статью?");
        },
        trimText: function (text) {
            var countSumbols = this.countSumbols;
            var trimmedText = "...";
            if (text.length > countSumbols) {
                trimmedText = text.slice(0, countSumbols) + "...";
            } else {
                trimmedText = text;
            }
            return trimmedText;
        }
    }
});