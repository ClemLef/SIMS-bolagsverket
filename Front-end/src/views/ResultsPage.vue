<template>

    <main>

        <v-card elevation="5" width="80%" class="mx-auto my-8">
            <v-tabs background-color="green darken-4" center-active dark right>
                <v-tooltip top color="green darken-4">
                    <template v-slot:activator="{ on, attrs }">
                        <v-btn icon class="ml-auto my-auto mr-3" :disabled='isDisabled' v-bind="attrs" v-on="on">
                            <v-icon>mdi-download</v-icon>
                        </v-btn>
                    </template>
                    <span>Download your result as pdf</span>
                </v-tooltip>
                
                <v-tooltip top color="green darken-4">
                    <template v-slot:activator="{ on, attrs }">
                        <v-btn icon class="my-auto mr-5" :disabled='isDisabled' @click="shareResult()" v-bind="attrs"
                        v-on="on">
                            <v-icon>mdi-share-variant</v-icon>
                        </v-btn>
                    </template>
                    <span>Share this result</span>
                </v-tooltip>
            </v-tabs>
            <component :is="formTaken()"></component>
        </v-card>
    </main>
</template>




<script>

import ResultsNotVisible from '@/components/ResultsNotVisible.vue';
import ResultsVisible from '../components/ResultsVisible.vue'
import ResultsAPI from '../controller/ResultsAPI.js'

export default {

    components: {
        // eslint-disable-next-line
        ResultsVisible,
        // eslint-disable-next-line
        ResultsNotVisible,
    },

    data: () => ({
        buttonDisabled: true,
        cards: [
            /* { title: 'What is sustainable investing ?', img_src: 'https://cloudinary.hbs.edu/hbsit/image/upload/s--YvTQW8XL--/f_auto,c_fill,h_375,w_750,/v20200101/9DD1E295483AB53C37A95A0D4BFE6F5D.jpg', source: "online.hbs.edu", description: "Investors can use several strategies to build and diversify their portfolios to ensure financial success. One emerging trend changing the way businesses and investors think about investing is a concept known as sustainable investing.", link: "https://online.hbs.edu/blog/post/sustainable-investing" },
            { title: 'F-skatt', img_src: 'https://skatteverket.se/images/18.1c68351d170ce554527e35/1584713519347/Logo_vit_bakgrund_FB.png', source: "skatteverket.se", description: "Om du bedriver näringsverksamhet i Sverige kan du efter ansökan hos Skatteverket bli godkänd för F-skatt", link: "https://www.skatteverket.se/foretag/etjansterochblanketter/svarpavanligafragor/fskatt/foretagfskattfaq/vemkanbligodkandforfskattochvadinnebardet.5.18e1b10334ebe8bc8000118949.html" },
            { title: 'Sustainable funds', img_src: 'https://www.fondbolagen.se/globalassets/om-oss/hallbarhet-artikelbild2-ny-webb.jpg?preset=jumbotron', source: "fondbolagen.se", description: "Knowing that the money they invest contributes to sustainable development is becoming increasingly important to savers.", link: "https://www.fondbolagen.se/en/Facts_Indices/sustainable-funds/" }, */
        ],

    }),
    methods: {
        redirectLink(link) {
            window.open(link);
        },

        createUrl() {
            let baseUrl = window.location.href.split('?')[0]
            let params = '?code=' + this.getCookie.result_code
            console.log(baseUrl + params)
            return baseUrl + params;
        },

        shareResult() {
            let shareUrl = this.createUrl()
            navigator.clipboard.writeText(shareUrl);
        },

        async loadResult(result_code) {
            let result = await ResultsAPI.getResult(result_code);
            if (result.data != "") {
                window.$cookies.config("1d")
                window.$cookies.set("isSustainable", result.data)
                //this.$router.go()
            } else {
                //handle the error
            }
        },

        formTaken() {
            // if a result cookie is present
            const result_code = this.$route.query.code
            console.log(result_code)
            

            /* if (result_code != null && window.$cookies.get('isSustainable').result_code != result_code){
                window.$cookies.remove('isSustainable')
                window.$cookies.config("1d");
                window.$cookies.set("isSustainable", this.loadResult(result_code))
            } */

            if (window.$cookies.get('isSustainable') == null && result_code == undefined) {
                return "ResultsNotVisible";
            } else {
                //console.log(window.$cookies.get('isSustainable').result_code)
                return "ResultsVisible";
            }
            /*if (result_code != undefined) {
                window.$cookies.remove("isSustainable");
                var caca
                (async () => { caca = await this.loadResult(result_code) })()
                console.log(caca)
                console.log("2", window.$cookies.get('isSustainable'))
                return "ResultsVisible";
            } else if (window.$cookies.get('isSustainable') != null) {
                return "ResultsVisible";
            } else {
                return "ResultsNotVisible";
            } */
            /*if (window.$cookies.get('isSustainable') != null && result_code == undefined) {
                console.log("1")
                return "ResultsVisible";
            } else if (window.$cookies.get('isSustainable') != null && result_code != undefined) {
                console.log("2")
                let result
                result = this.loadResult(result_code)
                window.$cookies.config("1d");
                window.$cookies.set("isSustainable", result)

                return "ResultsVisible";
            } else if (window.$cookies.get('isSustainable') == null && result_code != undefined) {
                console.log("3")
                let result
                (async () => {
                    result = await this.loadResult(result_code)
                })()
                window.$cookies.config("1d");
                window.$cookies.set("isSustainable", result)
                return "ResultsVisible";
            } else {
                console.log("4")
                return "ResultsNotVisible";
            }*/
        }
    },

    watch: {
        $route: {
            handler: function () {
                if(this.$route.query.code != undefined) {
                    console.log("bite")
                    window.$cookies.remove('isSustainable')
                    this.formTaken()
                }
                
            },
            deep: true
        }
    }, 

    computed: {

        /*if (window.$cookies.get('isSustainable') != null && result_code == undefined) {
             return "ResultsVisible";
         } else if (window.$cookies.get('isSustainable') != null && result_code != undefined) {
             window.$cookies.remove("isSustainable");
             let result
             (async () => {
                 result = await this.loadResult(result_code)
             })
             window.$cookies.config("1d");
             window.$cookies.set("isSustainable", result)
             
             return "ResultsVisible";
         } else if (window.$cookies.get('isSustainable') == null && result_code != undefined) {
             window.$cookies.remove("isSustainable");
             let result
             (async () => {
                 result = await this.loadResult(result_code)
             })
             console.log(result)
             window.$cookies.config("1d");
             window.$cookies.set("isSustainable", result)
             return "ResultsVisible";
         } else {
             return "ResultsNotVisible";
         }*/
        isDisabled() {
            // if a result cookie is present
            if (window.$cookies.get('isSustainable') != null) {
                // enable the buttons and return the results view
                return false;
            } else {
                // disable the buttons and return the error page
                return true;
            }
        },
        getCookie() {
            return window.$cookies.get('isSustainable');
        },
    },




}
</script>

<style>
.flex-wrapper {
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
}
</style>

