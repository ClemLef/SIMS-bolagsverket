<template>

    <!-- Home page view -->
    <main>
        <v-img src="../assets/home_background_vertical_blur.jpg" height="100vh">
            <v-card color="rgb(30, 60, 30, 0.70)" width="70%" class="mx-auto my-15">
                <v-card-text class="text-center white--text font-weight-bold">

                    <!-- Introduction text -->
                    <h1 class="text-h2 font-weight-medium my-10"> Welcome ! </h1>
                    <h2 class="text-h6 mb-4 mx-10"> Welcome to the sustainability barometer! This website will let you
                        assess the sustainability of your business idea. The service is based on artificial intelligence
                        AI and will help you determine on which areas you can improve and tips on what to do in order to
                        develop your business in a more sustainable way. </h2>

                    <!-- Button to redirect to the form page -->
                    <v-hover v-slot="{ hover }">
                        <v-btn class="v-btn ma-10 pa-6 white--text font-weight-bold" elevation="5" x-large
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectForm()">
                            <v-icon left> mdi-form-select </v-icon>
                            Take the test !
                            <v-icon right> mdi-chevron-right </v-icon>
                        </v-btn>
                    </v-hover>
                    <!-- Button to redirect to the info page -->
                    <v-hover v-slot="{ hover }">
                        <v-btn class="v-btn ma-10 pa-6 white--text font-weight-bold" elevation="5" x-large
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectInfoPage()">
                            <v-icon left> mdi-help-circle-outline </v-icon>
                            information page !
                            <v-icon right>mdi-chevron-right</v-icon>
                        </v-btn>
                    </v-hover>
                </v-card-text>
            </v-card>
        </v-img>
    </main>
</template>


<script>
// Define the name of the page 
document.title = 'Sustainability Barometer'
export default {
    methods: {
        // Redirect to the form page when button clicked
        redirectForm() {
            this.$router.push('/form')
        },
        // Redirect to the info page when button clicked
        redirectInfoPage() {
            this.$router.push('/info')
        },
    },

}
</script>