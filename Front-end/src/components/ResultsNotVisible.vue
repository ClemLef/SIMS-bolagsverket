<template>
    <div>
        <h1 class="mt-5">You haven't taken the test <span style="color: orange"><br/> Do it now : </span></h1>
        <v-btn class="ma-10 pa-6 white--text " color="blue-grey" elevation="5" x-large
                    rounded @click="redirect()">
                    Take the test ! 
                </v-btn>
    </div>
</template>

<script>
export default{
    methods: {
        redirect() {
            this.$router.push('/form')
        },
    }
}
</script>