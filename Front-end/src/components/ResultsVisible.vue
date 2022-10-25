<template>

    <div class="pa-5">
        <h1 v-if="this.titleSustainable()">Great results ! Your business idea is <span style="color: orangered">
                sustainable</span>.</h1>
        <h1 v-if="!this.titleSustainable()">You are almost there ! Your business idea is <span style="color: orangered">not
                sustainable</span>.<br />You can look at the articles below to try and improve the sustainability of
            your business idea :</h1>
        <v-row class="ma-10">
            <v-col>
                <v-btn class="pa-6 font-weight-bold  black--text " color="blue-grey lighten-5" elevation="5" x-large @click="redirect()">
                    Take the test again
                </v-btn>
            </v-col>
            <v-col>
                <v-text-field :value="getCookie.result_code" append-icon="mdi-content-copy" outlined label="Result Code" @click:append="copyCode()" readonly>
                </v-text-field>
            </v-col>
        </v-row>
        <h2 class="text-md-h5 my-5">You can see your results for each category below, just click on a section to display
            details.</h2>
        <v-expansion-panels popout>
            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.economical_flag)"
                    class="lighten-4 body-2 text-left font-weight-medium">
                    Economical
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.economical_flag)">
                            {{ whichIcon(getCookie.economical_flag) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :articles='articlesEco' :is="displaySustainable(getCookie.economical_flag)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.social_flag)"
                    class="body-2 text-left font-weight-medium">
                    Social
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.social_flag)">
                            {{ whichIcon(getCookie.social_flag) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :articles='articlesSoc' :is="displaySustainable(getCookie.social_flag)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.environment_flag)"
                    class="body-2 text-left font-weight-medium">
                    Environmental
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.environment_flag)">
                            {{ whichIcon(getCookie.environment_flag) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :articles='articlesEnv' :is="displaySustainable(getCookie.environment_flag)"></component>
            </v-expansion-panel>


            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.influence_flag)"
                    class="body-2 text-left font-weight-medium">
                    Influence
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.influence_flag)">
                            {{ whichIcon(getCookie.influence_flag) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :articles='articlesInf' :is="displaySustainable(getCookie.influence_flag)"></component>
            </v-expansion-panel>
        </v-expansion-panels>
    </div>


</template>

<script>
import ResultsVisibleSustainable from '@/components/ResultsVisibleSustainable.vue';
import ResultsVisibleNotSustainable from '@/components/ResultsVisibleNotSustainable.vue'
import ResultsAPI from '../controller/ResultsAPI.js'

export default {

    components: {
        // eslint-disable-next-line
        ResultsVisibleSustainable,
        // eslint-disable-next-line
        ResultsVisibleNotSustainable,
    },

    data: () => ({
        articles: {},
        articlesEco: [],
        articlesSoc: [],
        articlesEnv: [],
        articlesInf: [],
    }),

    methods: {

        copyCode() {
            navigator.clipboard.writeText(this.getCookie.result_code);
        },

        async loadArticles() {
            const request = await ResultsAPI.getArticles();
            this.articles = request.data;
            for (let i = 0; i < 9; i++) { // /!\ change the hard coded 9 
                switch (this.articles[i].category) {
                    case 0:
                        this.articlesEco.push(this.articles[i]);
                        break;
                    case 1:
                        this.articlesSoc.push(this.articles[i]);
                        break;
                    case 2:
                        this.articlesEnv.push(this.articles[i]);
                        break;
                    case 3:
                        this.articlesInf.push(this.articles[i]);
                        break;
                    default:
                        break;
                }
            }
        },

        redirectLink(link) {
            window.open(link);
        },
        redirect() {
            window.$cookies.remove('isSustainable');
            this.$router.push('/form');
        },
        whichColor(category) {
            if (category == 0) {
                return "red lighten-4";
            } else {
                return "green lighten-4"
            }
        },

        whichIcon(category) {
            if (category == 0) {
                return "mdi-alert-circle";
            } else {
                return "mdi-check";
            }
        },

        whichIconColor(category) {
            if (category == 0) {
                return "error";
            } else {
                return "teal";
            }
        },

        titleSustainable() {
            console.log("cook", this.getCookie)
            if (this.getCookie.global == 1) {
                return true;
            } else if (this.getCookie.global == 0) {
                return false;
            }
        },

        displaySustainable(category) {
            if (category == 1) {
                return "ResultsVisibleSustainable";
            } else if (category == 0) {
                return "ResultsVisibleNotSustainable";
            }
        }, 
        
        async loadResult() {
            const result_code = this.$route.query.code
            let result = await ResultsAPI.getResult(result_code);
            if (result.data != "") {
                window.$cookies.config("1d")
                window.$cookies.set("isSustainable", result.data)
                console.log("yes", window.$cookies.get('isSustainable').result_code)
            } else {
                //handle the error
            }
        },

        

    },

    computed: {
        getCookie() {
            return window.$cookies.get('isSustainable');
        },
        
        
    },
    created() {
        this.loadArticles();
        this.loadResult()
    },
}


</script>