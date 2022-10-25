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

        <v-container v-for="(info, index) in helpInfo" :key="info[index]" class="px-15 py-5">           
            <h2> {{info.headline}} </h2>
            <p class="my-3"> {{info.text}} </p>  
        </v-container>  
        <v-container v-for="(info, index) in tabHelpInfo" :key="info[index]" class="px-15 py-5">  
            <h2> {{info.headline}} </h2>
            <p class="my-3"> {{info.text}} </p>
            <!-- <p class="font-weight-bold"> {{info.source}} </p>   -->
        </v-container>

        
    </v-card>
    
</template>

<script>

    export default {

        
        methods: {},

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