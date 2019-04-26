var addarticle = new Vue({
    el: '#addarticle',
    data: {
        content: "",
        titleArticle:""
    },
    components: {
        'editor': Editor
    },
    methods: {
        saveArticle: function () {
        console.debug(this.content, this.titleArticle);
            var params = {
                titlearticle:this.titleArticle,
                content:this.content
                };
            axios.post("Content/AddArticle", params).then(function (response) {
                        
            });


        }}

});