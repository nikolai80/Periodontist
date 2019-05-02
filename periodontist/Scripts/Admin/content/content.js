var listArticles = new Vue({
    el: '#listArticles',
    data: {
        articles: []
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

        }
    }
});