<template>
    <!-- Component used when no code is in the URL (no test taken) -->
    <div class="pt-10">
        <!-- Illustration showing no results to display -->
        <v-flex my-10>
            <v-img class="mx-auto" max-height="200" max-width="200" :src="require('../assets/missing-form.png')">
            </v-img>
        </v-flex>
        <h1 class="my-3">Looks like you haven't taken the test</h1>

        <!-- Text to explain actions possible -->
        <h2 class="text-h5">
            <span class="orange--text text--darken-2">
                You can do it now
            </span>
            or enter your code to
            <span class="orange--text text--darken-2">
                access your result:
            </span>
        </h2>

        <v-row class="ma-10">
            <v-col>
                <!-- Button to redirect to the form page -->
                <v-btn class="font-weight-bold  white--text " color="green darken-3" elevation="5" x-large
                    @click="redirect()">
                    <v-icon left> mdi-form-select </v-icon>
                    Take the test!
                </v-btn>
            </v-col>
            <v-col class="pr-15">
                <!-- Text field to enter the code to access the result -->
                <v-text-field :error="this.setError" v-model="resultsCode" append-icon="mdi-chevron-right" outlined
                    label="Enter your code here to access your results!" @keydown.enter="loadResult()"
                    @click:append="loadResult()">
                </v-text-field>
                <!-- Error message in case the code is incorrect -->
                <v-alert dense text type="error" v-show="this.setError">
                    No result found with this code. Make sure you entered the correct one.
                </v-alert>
            </v-col>
        </v-row>
    </div>
</template>

<script>

// Import the js file handling the fetching of results
import ResultsAPI from '../controller/ResultsAPI.js'

export default {

    data() {
        return {
            // ResultsCode is a model used to get the value entered in the text field
            resultsCode: '',
            // Error is a model used to display the error message in case the code is incorrect
            error: false,
        }
    },

    methods: {
        // Redirect to the form page when button is clicked
        redirect() {
            this.$router.push('/form')
        },

        // Method to search for the result with the code provided
        async loadResult() {
            // Get the code entered 
            let code = this.getTextInput
            // Check that the code is not empty and that it's a number, else show error
            if (code != "" && !isNaN(code)) {
                // Fetch the result from the API
                let result = await ResultsAPI.getResult(code);
                // Redirect to the results page if response is not empty, else show error (no result found with this code)
                if (result.data != "") {
                    this.$router.push({ path: 'results', query: { code: code } })
                } else {
                    this.error = true
                }
            } else {
                this.error = true
            }
        },
    },

    computed: {
        // Return the code entered in the text field
        getTextInput() {
            return this.resultsCode;
        },
        // Return the status of the code found or not
        setError() {
            return this.error;
        }
    }
}
</script>