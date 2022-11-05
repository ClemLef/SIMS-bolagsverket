<template>
    <!-- Sub component of the results visible page, used to display a category sustainable -->
    <v-expansion-panel-content class="mt-5">
        Your answers show that your business idea is sustainable for the {{ category }} part.
        <br />You can find additional ressources here :
        <v-item-group class="mt-8">
            <v-container>
                <v-row>
                    <!-- Display all 3 articles in different vcard -->
                    <v-col v-for="(article, index) in articles" :key="article[index]" cols="12" md="4">
                        <v-item>
                            <v-card color="green lighten-5" elevation="5" class="mx-auto d-flex flex-column"
                                height="100%" max-width="400">
                                <v-card-title class="justify-center font-weight-medium"> {{ article.title }}
                                </v-card-title>
                                <v-divider></v-divider>
                                <v-card-text class="text--primary text-body-1">
                                    <div>{{ article.description }}</div>
                                </v-card-text>
                                <v-spacer></v-spacer>
                                <v-card-actions style="position: absolute, bottom: 0">
                                    <v-btn class="font-weight-bold text-decoration-underline" color="blue" text
                                        @click="redirectLink(article.url)">
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
</template>
<script>

export default {
    // These props are the data transmitted from the parent component (ResultsVisible)
    props: {
        articles: Array,
        category: String,
    },

    methods: {
        // Redirect to the linked article
        redirectLink(link) {
            window.open(link);
        },
    },
}
</script>