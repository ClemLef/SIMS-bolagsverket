<template>
    <v-card elevation="5" width="80%" class="mx-auto my-8">
        <v-tabs v-model='tab' background-color="green darken-4" center-active dark></v-tabs>
        <h5 class="text-md-h5 mt-5">Here you can see your results, just click on a section to display details.</h5>
        <div class="pa-5">
            <v-expansion-panels popout>
                <v-expansion-panel>
                    <v-expansion-panel-header disable-icon-rotate class="grey lighten-4 body-2 text-left font-weight-medium">
                        Economical
                        <template v-slot:actions>
                            <v-icon color="grey darken-2">
                                mdi-help
                            </v-icon>
                        </template>
                    </v-expansion-panel-header>
                    <v-expansion-panel-content class="mt-5">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                        incididunt ut
                        labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                        ullamco
                        laboris nisi ut aliquip ex ea commodo consequat.
                        <v-item-group>
                            <v-container>
                                <v-row>
                                    <v-col v-for="card in cards" :key="card" cols="12" md="4">
                                        <v-item>
                                            <v-card class="mx-auto" max-width="400">
                                                <v-img class="white--text align-end" height="200px"
                                                    :src="card.src">
                                                    <v-card-title> {{ card.title }} </v-card-title>
                                                </v-img>

                                                <v-card-subtitle class="pb-0">
                                                    {{ card.source }}
                                                </v-card-subtitle>

                                                <v-card-text class="text--primary">
                                                    <div>{{ card.description }}</div>
                                                </v-card-text>

                                                <v-card-actions>
                                                    <v-btn color="green" text>
                                                        Read more
                                                    </v-btn>
                                                </v-card-actions>
                                            </v-card>
                                        </v-item>
                                    </v-col>
                                </v-row>
                            </v-container>
                        </v-item-group>
                    </v-expansion-panel-content>
                </v-expansion-panel>

                <v-expansion-panel>
                    <v-expansion-panel-header disable-icon-rotate class="green lighten-4 body-2 text-left font-weight-medium">
                        Social
                        <template v-slot:actions>
                            <v-icon color="teal">
                                mdi-check
                            </v-icon>
                        </template>
                    </v-expansion-panel-header>
                    <v-expansion-panel-content class="mt-5">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                        incididunt ut
                        labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                        ullamco
                        laboris nisi ut aliquip ex ea commodo consequat.
                    </v-expansion-panel-content>
                </v-expansion-panel>

                <v-expansion-panel>
                    <v-expansion-panel-header disable-icon-rotate class="red lighten-4 body-2 text-left font-weight-medium">
                        Environmental
                        <template v-slot:actions>
                            <v-icon color="error">
                                mdi-alert-circle
                            </v-icon>
                        </template>
                    </v-expansion-panel-header>
                    <v-expansion-panel-content class="mt-5">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                        incididunt ut
                        labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                        ullamco
                        laboris nisi ut aliquip ex ea commodo consequat.
                    </v-expansion-panel-content>
                </v-expansion-panel>

                <v-expansion-panel>
                    <v-expansion-panel-header disable-icon-rotate class="red lighten-4 body-2 text-left font-weight-medium">
                        Positive influence
                        <template v-slot:actions>
                            <v-icon color="error">
                                mdi-alert-circle
                            </v-icon>
                        </template>
                    </v-expansion-panel-header>
                    <v-expansion-panel-content class="mt-5">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
                        incididunt ut
                        labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                        ullamco
                        laboris nisi ut aliquip ex ea commodo consequat.
                    </v-expansion-panel-content>
                </v-expansion-panel>
            </v-expansion-panels>
        </div>
    </v-card>
</template>

<script>
export default {
    data: () => ({
        cards: [
            { title: 'Pre-fab homes', src: 'https://cdn.vuetifyjs.com/images/cards/house.jpg', source: "Bolagsverket", description: "This is a description for the first article"},
            { title: 'Favorite road trips', src: 'https://cdn.vuetifyjs.com/images/cards/road.jpg', source: "Skatteverket", description: "This is a description for the second article" },
            { title: 'Best airlines', src: 'https://cdn.vuetifyjs.com/images/cards/plane.jpg', source: "Naturvardsverket", description: "This is a description for the third article" },
        ],
    }),
}
</script>