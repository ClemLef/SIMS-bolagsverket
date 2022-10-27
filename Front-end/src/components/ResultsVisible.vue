<template>

    <div v-if="dataLoaded" class="pa-10">
        <h1 v-if="this.titleSustainable()">Great results ! Your business idea is <span style="color: orangered">
                sustainable</span>.</h1>
        <h1 v-if="!this.titleSustainable()" class="mb-10">You are almost there ! Your business idea is <span
                style="color: orangered">not
                sustainable</span>.<br />You can look at the articles below to try and improve the sustainability of
            your business idea.</h1>

        <h3 class="text-h6 mb-10"> You can copy the at the end of the page to access your result at a later time ! </h3>

        <h2 class="text-md-h5 mb-10 ">You can see your results for each category below, just click on a section to
            display
            details.</h2>

        <v-expansion-panels popout multiple>
            <v-expansion-panel>

                <v-expansion-panel-header :class="this.whichColor(this.result.data.economical_flag)"
                    class="body-2 text-left font-weight-medium">
                    <div>
                        <v-icon class="mr-5" :color="whichIconColor(result.data.economical_flag)">
                            {{ whichIcon(result.data.economical_flag) }}
                        </v-icon>
                        Economical
                    </div>
                </v-expansion-panel-header>

                <component :articles='articlesEco' :category="'economical'"
                    :is="displaySustainable(result.data.economical_flag)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header :class="this.whichColor(this.result.data.social_flag)"
                    class="body-2 text-left font-weight-medium">
                    <div>
                        <v-icon class="mr-5" :color="whichIconColor(result.data.social_flag)">
                            {{ whichIcon(result.data.social_flag) }}
                        </v-icon>
                        Social
                    </div>
                </v-expansion-panel-header>
                <component :articles='articlesSoc' :category="'social'"
                    :is="displaySustainable(result.data.social_flag)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate
                    :class="this.whichColor(this.result.data.environment_flag)"
                    class="body-2 text-left font-weight-medium">
                    <div>
                        <v-icon class="mr-5" :color="whichIconColor(result.data.environment_flag)">
                            {{ whichIcon(result.data.environment_flag) }}
                        </v-icon>
                        Environmental
                    </div>
                </v-expansion-panel-header>
                <component :articles='articlesEnv' :category="'environmental'"
                    :is="displaySustainable(result.data.environment_flag)"></component>
            </v-expansion-panel>


            <v-expansion-panel>
                <v-expansion-panel-header :class="this.whichColor(this.result.data.influence_flag)"
                    class="body-2 text-left font-weight-medium">
                    <div>
                        <v-icon class="mr-5" :color="whichIconColor(result.data.influence_flag)">
                            {{ whichIcon(result.data.influence_flag) }}
                        </v-icon>
                        Influence
                    </div>
                </v-expansion-panel-header>
                <component :articles='articlesInf' :category="'positive influence'"
                    :is="displaySustainable(result.data.influence_flag)"></component>
            </v-expansion-panel>
        </v-expansion-panels>


        <v-row class="ma-15">
            <v-col>
                <v-btn class="mt-1 font-weight-bold  white--text " color="green darken-3" elevation="5" x-large
                    @click="redirect()">
                    <v-icon left> mdi-chevron-left </v-icon>
                    <v-icon left> mdi-form-select </v-icon>
                    Take the test again!
                </v-btn>
            </v-col>
            <v-col>
                <v-text-field :value="result.data.result_code" :success=copySuccess :append-icon=copyIcon outlined label="Result Code"
                    @click:append="copyCode()" readonly>
                </v-text-field>

            </v-col>
        </v-row>
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
        dataLoaded: false,
        category: "",
        copyIcon: "mdi-content-copy",
        copySuccess: false,
    }),

    methods: {

        copyCode() {
            this.copyIcon = "mdi-checkbox-marked-outline"
            this.copySuccess = true
            //the commented function should be the one used but is not working for demonstration purposes over http
            //navigator.clipboard.writeText(this.result.data.result_code);
            document.execCommand('copy')
        },

        async loadArticles() {
            const request = await ResultsAPI.getArticles();
            this.articles = request.data;
            for (let i = 0; i < 12; i++) { // /!\ change the hard coded 9 
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

        async loadResult() {
            const result_code = this.$route.query.code
            this.result = await ResultsAPI.getResult(result_code);
            if (this.result.data == "") {
                //do smth
            } else {
                this.dataLoaded = true;
            }
        },

        redirectLink(link) {
            window.open(link);
        },
        redirect() {
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
                return "mdi-leaf-off";
            } else {
                return "mdi-leaf";
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
            if (this.result.data.global == 1) {
                return true;
            } else if (this.result.data.global == 0) {
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
    },

    created() {
        this.loadArticles();
        this.loadResult();
    },
}
</script>