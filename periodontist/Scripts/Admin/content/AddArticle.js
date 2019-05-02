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
            var params = {
                titlearticle:this.titleArticle,
                content:this.content
                };
            axios.post("AddArticle", params).then(function (response) {
                 //window.location.replace("/Content");      
            });


        }}

});