<template>
    <v-img dark src="../assets/home_background_vertical_blur.jpg" height="100vh" class="pa-10">

        <!-- <v-card color="rgb(255, 255, 255, 0.70)" width="70%">
            <v-card-text class="text-center font-weight-bold">  -->

                <v-row align="center" justify="center" class="mt-10 pa-10">
                    <v-col cols="12">
                        <h1 class="text-h1 font-weight-medium my-10"> Welcome </h1>
                        <h4 class="text-h5 mb-4 text-left" width> Welcome to the sustainability barometer! This website will let you assess the sustainability of your business idea. The service is based on artificial intelligence AI and will help you determine on which areas you can improve and tips on what to do in order to develop your business in a more sustainable way. </h4>
                        <v-hover v-slot="{ hover }">
                            <v-btn class="v-btn ma-10 pa-6 white--text font-weight-bold" elevation="5" x-large rounded
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectForm()">
                                <v-icon left> mdi-form-select </v-icon> 
                                Take the test !
                                <v-icon right> mdi-chevron-right </v-icon>
                            </v-btn>
                        </v-hover>
                        <v-hover v-slot="{ hover }">
                            <v-btn class="v-btn ma-10 pa-6 white--text font-weight-bold" elevation="5" x-large rounded
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectInfoPage()"> 
                                <v-icon left> mdi-help-circle-outline </v-icon>
                                info page !
                                <v-icon right>mdi-chevron-right</v-icon>
                            </v-btn>
                        </v-hover>
                    </v-col>
                </v-row>

                
            
            <!-- </v-card-text> -->
        <!-- </v-card> -->

    </v-img>
</template>


<script>
document.title = 'Sustainability Barometer'
export default {
    data: () => ({
        loading: false,
    }),
    methods: {
        redirectForm() {
            this.$router.push('/form')
        },
        redirectInfoPage() {
            this.$router.push('/info')
        },
    }, 
    
}
</script>