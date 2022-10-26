<template>

    <v-card width="90%" class="mx-auto my-10 text-left">

        <v-container class="text-center">
            <h1 class="my-5">
                {{infoPageHeader.header}}
            </h1>
            <h3 class="my-10 mx-5">
                {{infoPageHeader.text}}
            </h3>
            <v-divider class="my-5"> </v-divider>
        </v-container>

        <div class="px-15 py-5">

            
            <v-container v-for="(info, index) in helpInfo" :key="info[index]">           
                <h2> {{info.headline}} </h2>
                <p class="my-3"> {{info.text}} </p>  
            </v-container>  

            <v-container v-for="(info, index) in tabHelpInfo" :key="info[index]">  
                <h2> {{info.headline}} </h2>
                <p class="my-3"> {{info.text}} </p>
                <!-- <p class="font-weight-bold"> {{info.source}} </p>   -->
                
            </v-container>
            
            <v-container>
                <v-divider class="my-5"> </v-divider>

                <v-row class="text-center">

                    <v-flex class="mt-6" > 
                        <H4 class="text-h6"> Go to HomePage! </H4>
                        
                        <v-hover v-slot="{ hover }">
                            <v-btn class="v-btn my-5 white--text font-weight-bold" elevation="5" x-large 
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectHome()">
                                <v-icon left> mdi-page-previous-outline </v-icon> 
                                Home Page ! 
                            </v-btn>
                        </v-hover>
                    </v-flex>

                    <v-flex class="mt-6" > 
                        <H4 class="text-h6"> If you are ready, then take the test here! </H4>
                        
                        <v-hover v-slot="{ hover }">
                            <v-btn class="v-btn my-5 white--text font-weight-bold" color="primary" elevation="5" x-large 
                            :style="{ 'background-color': hover ? '#81C784' : 'green' }" @click="redirectForm()">
                                <v-icon left> mdi-form-select </v-icon> 
                                Take the test ! 
                                <v-icon right> mdi-chevron-right </v-icon>
                            </v-btn>
                        </v-hover>
                    </v-flex>
                    
                </v-row>
            
            </v-container>
    
        </div>

        
    </v-card>
    
</template>

<script>

    export default {

        
        methods: {
            redirectForm() {
                this.$router.push('/form')
            },
            redirectHome() {
                this.$router.push('/')
            },

        },

        computed: {
            helpInfo(){
                return this.$store.state.helpInfo;
            },
            tabHelpInfo(){
                return this.$store.state.tabHelpInfo;
            }
        },
        
        data: () => ({
            infoPageHeader: {
                header: "Information page",
                text: "Welcome to the sustainability barometer! This website will let you assess the sustainability of your business idea. The service is based on artificial intelligence AI and will help you determine on which areas you can improve and tips on what to do in order to develop your business in a more sustainable way.",
            },
        })
    }

</script>