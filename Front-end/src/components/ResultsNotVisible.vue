<template>
    <div class="pa-10">
        <v-flex my-10>
            <v-img class="mx-auto" max-height="200" max-width="200" :src="require('../assets/missing-form.png')">
            </v-img>
        </v-flex>
        <h1 class="my-5">Looks like you haven't taken the test</h1>
        <h3><span style="color: orange">You can do it now </span>or enter your code to <span
                style="color: orange">access your result: </span></h3>

        <v-row class="ma-10">
            <v-col>
                <v-btn class="pa-6 white--text " color="blue-grey" elevation="5" x-large rounded @click="redirect()">
                    Take the test !
                </v-btn>
            </v-col>
            <v-col>
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
            console.log(result_code)
            if (result_code != "") {
                let result = await ResultsAPI.getResult(result_code);
                console.log(result)
                if (result.data != "") {
                    window.$cookies.config("1d");
                    window.$cookies.set("isSustainable", result.data);
                    this.$router.go();
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