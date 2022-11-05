<template>
    <!-- Component used when a code is present in the URL (result to show) 
    Only show this component when all data has been loaded -->
    <div v-if="dataLoaded" class="pa-10">
        <!-- Display a title depending on the result -->
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

        <!-- Expansion panels made to separate the results by category -->
        <v-expansion-panels popout multiple>
            <v-expansion-panel>
                <!-- Color changes based on the result (green = sustainable, red = not sustainable) -->
                <v-expansion-panel-header :class="this.whichColor(this.result.data.economical_flag)"
                    class="body-2 text-left font-weight-medium">
                    <div>
                        <v-icon class="mr-5" :color="whichIconColor(result.data.economical_flag)">
                            {{ whichIcon(result.data.economical_flag) }}
                        </v-icon>
                        Economical
                    </div>
                </v-expansion-panel-header>
                <!-- Load component based on the result of this category (sustainable or not) and forward articles to this component -->
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
                <!-- Button to redirect to the test page -->
                <v-btn class="mt-1 font-weight-bold  white--text " color="green darken-3" elevation="5" x-large
                    @click="redirect()">
                    <v-icon left> mdi-chevron-left </v-icon>
                    <v-icon left> mdi-form-select </v-icon>
                    Take the test again!
                </v-btn>
            </v-col>
            <v-col>
                <!-- Text field to copy the results code (read only) -->
                <v-text-field :value="result.data.result_code" :success=copySuccess :append-icon=copyIcon outlined
                    label="Result Code" @click:append="copyCode()" readonly>
                </v-text-field>
            </v-col>
        </v-row>
    </div>


</template>

<script>
// Import all the components 
import ResultsVisibleSustainable from '@/components/ResultsVisibleSustainable.vue';
import ResultsVisibleNotSustainable from '@/components/ResultsVisibleNotSustainable.vue'
import ResultsAPI from '../controller/ResultsAPI.js'

export default {

    components: {
        ResultsVisibleSustainable,
        ResultsVisibleNotSustainable,
    },

    data: () => ({
        // Object containing all of the articles
        articles: {},
        // List of Ecological articles
        articlesEco: [],
        // List of Social articles
        articlesSoc: [],
        // List of Environmental articles
        articlesEnv: [],
        // List of Positive influence articles
        articlesInf: [],
        // Variable used to wait for all data to be loaded before displaying 
        dataLoaded: false,
        // Variable used to forward the category to the sub component 
        category: "",
        // Base icon to display, changed when text field button is clicked
        copyIcon: "mdi-content-copy",
        // Used to display the status of the text field when user has copied the code
        copySuccess: false,
    }),

    methods: {

        // Method used to copy the code to the clipboard
        copyCode() {
            this.copyIcon = "mdi-checkbox-marked-outline"
            this.copySuccess = true
            // The following function is not working over HTTP (unsecure)
            navigator.clipboard.writeText(this.result.data.result_code);
        },

        // Method to get the articles from the database
        async loadArticles() {
            // Get the response from the API
            const request = await ResultsAPI.getArticles();
            // Extract the data from the repsonse
            this.articles = request.data;
            // Sort the articles based on the category
            for (let i = 0; i < 12; i++) {
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

        // Method to search for the result with the code provided 
        async loadResult() {
            // Get the code from the URL
            const resultCode = this.$route.query.code
            // Check that the code is not empty and that it's a number, else show error
            this.result = await ResultsAPI.getResult(resultCode);
            if (this.result.data == "") {
                // Error not handled
            } else {
                // Result has been loaded
                this.dataLoaded = true;
            }
        },

        // Redirect to the form page
        redirect() {
            this.$router.push('/form');
        },

        // Display the color of the expansion panel header based on the result (red or green)
        whichColor(category) {
            if (category == 0) {
                return "red lighten-4";
            } else {
                return "green lighten-4"
            }
        },

        // Display the icon of the expansion panel header based on the result (leaf or crossed leaf)
        whichIcon(category) {
            if (category == 0) {
                return "mdi-leaf-off";
            } else {
                return "mdi-leaf";
            }
        },

        // Display the color of the icon of the panel header based on the result (red or green)
        whichIconColor(category) {
            if (category == 0) {
                return "error";
            } else {
                return "teal";
            }
        },

        // Display the title of the page based on the global result (sustainable or not sustainable)
        titleSustainable() {
            if (this.result.data.global == 1) {
                return true;
            } else if (this.result.data.global == 0) {
                return false;
            }
        },

        // Chooses which sub component to display based on the result for this category for each panel (the text and color are not the same)
        displaySustainable(category) {
            if (category == 1) {
                return "ResultsVisibleSustainable";
            } else if (category == 0) {
                return "ResultsVisibleNotSustainable";
            }
        },
    },

    created() {
        // when the page is created, load the articles and results 
        this.loadArticles();
        this.loadResult();
    },
}
</script>