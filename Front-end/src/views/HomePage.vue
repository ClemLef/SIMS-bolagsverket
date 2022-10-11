<template>
    <v-img dark src="../assets/home_background_vertical_blur.jpg" height="100vh">
        <div class="card-body">Returned Id: {{postId}}</div>
        <v-row align="center" justify="center">
            <v-col class="text-center" cols="12">
                <h1 class="text-h1 font-weight-thin my-10"> Welcome </h1>
                <h4 class="subheading mb-4"> Welcome to the Sustainability Barometer </h4>
                <h3 class="text-md-h4">This website will let you assess the sustainability of your business idea.</h3>
                <v-hover v-slot="{ hover }">
                    <v-btn class="v-btn ma-10 pa-6 white--text " elevation="5" x-large rounded
                        :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirect">Take the test !
                        <v-icon right>mdi-chevron-right</v-icon>
                    </v-btn>
                </v-hover>

            </v-col>
        </v-row>
    </v-img>
</template>


<script>

import axios from 'axios';

export default {
    name: 'HomePage',
    data: () => ({
        drawer: false,
        group: null,
        resultId: null,
    }),
    created() {
        // Simple POST request with a JSON body using axios
        const article = { title: "Vue POST Request Example" };
        const config = {
            headers:{
                "Access-Control-Allow-Origin": "*"
            }
        }
        axios.post("http://127.0.0.1:5000", article, config)
            .then(response => this.articleId = response.data.id);
    },

    methods: {
        redirect() {
            this.$router.push('/form')
        }
    },
}
</script>