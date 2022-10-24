<template>
    <div class="pa-10">
        <v-flex my-10>
            <v-img class="mx-auto" max-height="200" max-width="200" :src="require('../assets/missing-form.png')">
            </v-img>
        </v-flex>
        <h1 class="mt-5">Looks like you haven't taken the test <span style="color: orange"><br /> Do it now : </span>
        </h1>
        <v-row class="ma-10">
            <v-col>
                <v-btn class="pa-6 white--text " color="blue-grey" elevation="5" x-large rounded @click="redirect()">
                    Take the test !
                </v-btn>
            </v-col>
            <v-col>
                <v-text-field :color="this.getErrorColor" v-model="resultsCode" append-icon="mdi-chevron-right" outlined
                    label="Result Code" @click:append="loadResult()">
                </v-text-field>
                <v-alert dense text type="error" v-show="this.getErrorColor">
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
        displayResult() {


        },
        async loadResult() {
            let result_code = this.getTextInput
            let result = await ResultsAPI.getResult(result_code);
            console.log(result.data)
            if (result.data != "") {
                window.$cookies.config("1d");
                window.$cookies.set("isSustainable", result.data);
                this.$router.go()
            } else {
                this.error = true
            }

        },

    },
    computed: {
        getTextInput() {
            return this.resultsCode;
        },
        getErrorColor() {
            if (this.error) {
                return 'red'
            } else {
                return ''
            }
        }
    }
}
</script>