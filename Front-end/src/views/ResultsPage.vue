<template>
    <main>
        <!-- v-card is used here to keep the design consistent -->
        <v-card elevation="5" width="80%" class="mx-auto my-8">
            <v-tabs background-color="green darken-4" center-active dark right>
                <!-- Commented out the download as pdf button because feature is not yet implemented -->
                <!-- <v-tooltip top color="green darken-4">
                    <template v-slot:activator="{ on, attrs }">
                        <v-btn icon class="ml-auto my-auto mr-3" :disabled='isDisabled()' v-bind="attrs" v-on="on">
                            <v-icon>mdi-download</v-icon>
                        </v-btn>
                    </template>
                    <span>Download your result as pdf</span>
                </v-tooltip> -->

                <!-- button to share the result -->
                <v-tooltip top color="green darken-4">
                    <template v-slot:activator="{ on, attrs }">
                        <v-btn icon class="ml-auto my-auto mr-3" :disabled='isDisabled()' @click="shareResult()"
                            v-bind="attrs" v-on="on">
                            <v-icon>mdi-share-variant</v-icon>
                        </v-btn>
                    </template>
                    <span>Share this result</span>
                </v-tooltip>
            </v-tabs>
            <!-- component to be loaded depending if there is a result to display or not -->
            <component :is="formTaken()"></component>
        </v-card>
    </main>
</template>

<script>

import ResultsNotVisible from '@/components/ResultsNotVisible.vue';
import ResultsVisible from '../components/ResultsVisible.vue'

export default {

    components: {
        ResultsVisible,
        ResultsNotVisible,
    },

    data: () => ({
        // Variable used to enable/disable a button if there is a result to display or not
        buttonDisabled: true,
    }),
    
    methods: {
        // method used to create a URL to share the result
        createUrl() {
            // Get the base path of the actual URL (www.example.com)
            let baseUrl = window.location.href.split('?')[0]
            // Include the code (?code=464562)
            let params = '?code=' + this.$route.query.code
            // Return formed URL
            return baseUrl + params;
        },

        // Method used to copy the code to the clipboard (not working in HTTP)
        shareResult() {
            let shareUrl = this.createUrl()
            navigator.clipboard.writeText(shareUrl);
        },

        // Check if the user has taken the form before accessing the result
        formTaken() {
            // Check if a code is present in the URL (www.example.com?code=46565) and returns the component to load
            if (this.$route.query.code == null) {
                return "ResultsNotVisible";
            } else {
                return "ResultsVisible";
            }
        },

        // Check if the user has taken the form before being able to share his result
        isDisabled() {
            // Check if a code is present in the URL (www.example.com?code=46565) and returns the state of the share button
            if (this.$route.query.code != null) {
                // disable the button
                return false;
            } else {
                // enable the button
                return true;
            }
        },
    },

    watch: {
        // Watcher used to scan if the form was taken
        $route: {
            handler: function () {
                this.formTaken()
            },
            deep: true
        }
    },

    created() {
        // When page is created, get the code from the URL (can be null if no code is in the URL)
        this.result_code = this.$route.query.code;
    }
}
</script>

<style>
/* Used to display the background correctly */
.flex-wrapper {
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
}
</style>

