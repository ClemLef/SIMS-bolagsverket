<template>
    <v-alert prominent type="error">
        <v-row :align="center">
            <v-col class="grow">
                Looks like something went wrong while sending the data to the server, wait a few seconds and try again.
            </v-col>
            <v-col class="shrink">
                <v-btn @click="redirect()">
                    Help
                </v-btn>
            </v-col>
        </v-row>
    </v-alert>
</template>

<script>
export default {
    methods: {
        redirect() {
            this.$router.push("/help");
        }
    }
}
</script>