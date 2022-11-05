<template>
    <!-- Error component used when an error occured while sending data to the AI -->
    <v-alert prominent type="error">
        <v-row align="center">
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
            // Provide some way for the user to contact site owner or admin
        }
    }
}
</script>