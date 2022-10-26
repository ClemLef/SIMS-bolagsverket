<template>
    <div class="pt-10">
        <v-flex my-10>
            <v-img class="mx-auto" max-height="200" max-width="200" :src="require('../assets/missing-form.png')">
            </v-img>
        </v-flex>
        <h1 class="my-3">Looks like you haven't taken the test</h1>

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
                <v-btn class="pa-6 mt-12 font-weight-bold  white--text " color="green darken-3" elevation="5" x-large @click="redirect()">
                    <v-icon left> mdi-form-select </v-icon>
                    Take the test!
                </v-btn>
            </v-col>
            <v-col>
                <p class="text-h6 text-left"> Enter your code below to access your previous results! </p>
                <v-text-field :error="this.setError" v-model="resultsCode" append-icon="mdi-chevron-right" outlined
                    label="Result Code" @keydown.enter="loadResult()" @click:append="loadResult()">
                </v-text-field>
                <v-alert dense text type="error" v-show="this.setError">
                    No result found with this code. Make sure you entered the correct one.
                </v-alert>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import ResultsAPI from '../controller/ResultsAPI.js'

export default {
    data() {
        return {
            resultsCode: '',
            error: false,
        }
    },
    methods: {
        redirect() {
            this.$router.push('/form')
        },
        async loadResult() {
            let result_code = this.getTextInput
            if (result_code != "") {
                let result = await ResultsAPI.getResult(result_code);
                if (result.data != "") {
                    this.$router.push({ path: 'results', query: { code: result_code } })
                } else {
                    this.error = true
                }
            } else {
                this.error = true
            }
        },
    },

    computed: {
        getTextInput() {
            return this.resultsCode;
        },
        setError() {
            if (this.error) {
                return true
            } else {
                return false
            }
        }
    }
}
</script>