<template>

    <div class="pa-5">
        <h1 v-if="this.titleSustainable()">Great results ! Your business idea is <span style="color: orange">
                sustainable</span>.</h1>
        <h1 v-if="!this.titleSustainable()">You are almost there ! Your business idea is <span style="color: orange">not
                sustainable</span>.<br />You can look at the articles below to try and improve the sustainability of
            your business idea :</h1>
        <v-btn class="ma-10 pa-6 white--text " color="blue-grey" elevation="5" x-large rounded @click="redirect()">
            Take the test again
        </v-btn>
        <h5 class="text-md-h5 my-5">You can see your results for each category below, just click on a section to display
            details.</h5>
        <v-expansion-panels popout>
            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.eco)"
                    class="lighten-4 body-2 text-left font-weight-medium">
                    Economical
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.eco)">
                            {{ whichIcon(getCookie.eco) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :is="displaySustainable(getCookie.eco)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.soc)"
                    class="body-2 text-left font-weight-medium">
                    Social
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.soc)">
                            {{ whichIcon(getCookie.soc) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :is="displaySustainable(getCookie.soc)"></component>
            </v-expansion-panel>

            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.env)"
                    class="body-2 text-left font-weight-medium">
                    Environmental
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.env)">
                            {{ whichIcon(getCookie.env) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :is="displaySustainable(getCookie.env)"></component>
            </v-expansion-panel>


            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="this.whichColor(this.getCookie.inf)"
                    class="body-2 text-left font-weight-medium">
                    Influence
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor(getCookie.inf)">
                            {{ whichIcon(getCookie.inf) }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <component :is="displaySustainable(getCookie.inf)"></component>
            </v-expansion-panel>
        </v-expansion-panels>
    </div>


</template>

<script>
import ResultsVisibleSustainable from '@/components/ResultsVisibleSustainable.vue';
import ResultsVisibleNotSustainable from '@/components/ResultsVisibleNotSustainable.vue'
export default {
    components: {
        // eslint-disable-next-line
        ResultsVisibleSustainable,
        // eslint-disable-next-line
        ResultsVisibleNotSustainable,
    },


    methods: {
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
            if (this.getCookie.global == "Sustainable") {
                return true;
            } else if (this.getCookie.global == "NOT Sustainable") {
                return false;
            }
        },

        displaySustainable(category) {
            if (category == 1) {
                console.log("bite");
                return "ResultsVisibleSustainable";
            } else if (category == 0) {
                return "ResultsVisibleNotSustainable";
            }
        }

    },
    computed: {
        getCookie() {
            return window.$cookies.get('isSustainable');
        },
    }
}


</script>