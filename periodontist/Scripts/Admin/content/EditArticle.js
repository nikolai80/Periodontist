var addarticle = new Vue({
    el: '#addarticle',
    data: {
        id:"",
        content: "",
        titleArticle:""
    },
    components: {
        'editor': Editor
    },
    methods: {
        saveArticle: function () {
            var params = {
                titlearticle:this.titleArticle,
                content:this.content
                };
            axios.post("AddArticle", params).then(function (response) {
                 window.location.replace("/Admin/content");      
            });


        },
        updateArticle: function() {
            var params = {
                ID:this.id,
                titlearticle:this.titleArticle,
                content:this.content
            };
            axios.post("UpdateArticle", params).then(function (response) {
                window.location.replace("/Admin/content");      
            });

        }
    }

});