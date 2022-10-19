<template>

    <div class="pa-5">
        <h1>Great results ! Your business idea is <span style="color: orange">{{this.getCookie().global}}</span>.
        </h1>
        <v-btn class="ma-10 pa-6 white--text " color="blue-grey" elevation="5" x-large rounded @click="redirect()">
            Take the test again
        </v-btn>
        <h5 class="text-md-h5 my-5">You can see your results for each category below, just click on a section to display
            details.</h5>
        <v-expansion-panels popout>
            <v-expansion-panel>
                <v-expansion-panel-header disable-icon-rotate :class="whichColor('eco')"
                    class="lighten-4 body-2 text-left font-weight-medium">
                    Economical
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor('eco')">
                            {{ `mdi-${whichIcon('eco')}` }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <v-expansion-panel-content class="mt-5">
                    We're sorry but we weren't able to assess the econonomical part of your business idea.
                    <br>If you think it's not normal, you can <router-link to="/contact">contact us here
                    </router-link>
                    <v-item-group class="mt-8">
                        <v-container>
                            <v-row>
                                <v-col v-for="(card, index) in cards" :key="card[index]" cols="12" md="4">
                                    <v-item>
                                        <v-card class="mx-auto d-flex flex-column" height="100%" max-width="400">
                                            <v-img class="white--text align-end" height="200px" :src="card.img_src">
                                                <v-card-title style="text-shadow: black 1px 0 10px;"> {{ card.title
                                                }} </v-card-title>
                                            </v-img>

                                            <v-card-subtitle class="pb-0">
                                                {{ card.source }}
                                            </v-card-subtitle>

                                            <v-card-text class="text--primary">
                                                <div>{{ card.description }}</div>
                                            </v-card-text>
                                            <v-spacer></v-spacer>
                                            <v-card-actions style="position: absolute, bottom: 0">
                                                <v-btn color="green" text @click="redirect_link(card.link)">
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
                <v-expansion-panel-header disable-icon-rotate :class="whichColor('soc')"
                    class="green lighten-4 body-2 text-left font-weight-medium">
                    Social
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor('soc')">
                            {{ `mdi-${whichIcon('soc')}` }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <v-expansion-panel-content class="mt-5">
                    Your answers show that your business idea is sustainable for the social part.
                    <br>You can find additional ressources here :
                    <v-item-group class="mt-8">
                        <v-container>
                            <v-row>
                                <v-col v-for="(card, index) in cards" :key="card[index]" cols="12" md="4">
                                    <v-item>
                                        <v-card class="mx-auto d-flex flex-column" height="100%" max-width="400">
                                            <v-img class="white--text align-end" height="200px" :src="card.img_src">
                                                <v-card-title style="text-shadow: black 1px 0 10px;"> {{ card.title
                                                }} </v-card-title>
                                            </v-img>

                                            <v-card-subtitle class="pb-0">
                                                {{ card.source }}
                                            </v-card-subtitle>

                                            <v-card-text class="text--primary">
                                                <div>{{ card.description }}</div>
                                            </v-card-text>
                                            <v-spacer></v-spacer>
                                            <v-card-actions style="position: absolute, bottom: 0">
                                                <v-btn color="green" text @click="redirect_link(card.link)">
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
                <v-expansion-panel-header disable-icon-rotate :class="whichColor('env')"
                    class="body-2 text-left font-weight-medium">
                    Environmental
                    <template v-slot:actions>
                        <v-icon :color="whichIconColor('env')">
                            {{ `mdi-${whichIcon('env')}` }}
                        </v-icon>
                    </template>
                </v-expansion-panel-header>
                <v-expansion-panel-content class="mt-5">
                    Your answers show that you still have progress to make in the environmental part of
                    sustainability.
                    Don't worry, we've gathered some useful links for you to reand and explore.
                    <v-item-group class="mt-8">
                        <v-container>
                            <v-row>
                                <v-col v-for="(card, index) in cards" :key="card[index]" cols="12" md="4">
                                    <v-item>
                                        <v-card class="mx-auto d-flex flex-column" height="100%" max-width="400">
                                            <v-img class="white--text align-end" height="200px" :src="card.img_src">
                                                <v-card-title style="text-shadow: black 1px 0 10px;"> {{ card.title
                                                }} </v-card-title>
                                            </v-img>

                                            <v-card-subtitle class="pb-0">
                                                {{ card.source }}
                                            </v-card-subtitle>

                                            <v-card-text class="text--primary">
                                                <div>{{ card.description }}</div>
                                            </v-card-text>
                                            <v-spacer></v-spacer>
                                            <v-card-actions style="position: absolute, bottom: 0">
                                                <v-btn color="green" text @click="redirectLink(card.link)">
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
        </v-expansion-panels>
    </div>


</template>

<script>
export default {

    data: () => ({
        cards: [
            { title: 'What is sustainable investing ?', img_src: 'https://cloudinary.hbs.edu/hbsit/image/upload/s--YvTQW8XL--/f_auto,c_fill,h_375,w_750,/v20200101/9DD1E295483AB53C37A95A0D4BFE6F5D.jpg', source: "online.hbs.edu", description: "Investors can use several strategies to build and diversify their portfolios to ensure financial success. One emerging trend changing the way businesses and investors think about investing is a concept known as sustainable investing.", link: "https://online.hbs.edu/blog/post/sustainable-investing" },
            { title: 'F-skatt', img_src: 'https://skatteverket.se/images/18.1c68351d170ce554527e35/1584713519347/Logo_vit_bakgrund_FB.png', source: "skatteverket.se", description: "Om du bedriver näringsverksamhet i Sverige kan du efter ansökan hos Skatteverket bli godkänd för F-skatt", link: "https://www.skatteverket.se/foretag/etjansterochblanketter/svarpavanligafragor/fskatt/foretagfskattfaq/vemkanbligodkandforfskattochvadinnebardet.5.18e1b10334ebe8bc8000118949.html" },
            { title: 'Sustainable funds', img_src: 'https://www.fondbolagen.se/globalassets/om-oss/hallbarhet-artikelbild2-ny-webb.jpg?preset=jumbotron', source: "fondbolagen.se", description: "Knowing that the money they invest contributes to sustainable development is becoming increasingly important to savers.", link: "https://www.fondbolagen.se/en/Facts_Indices/sustainable-funds/" },
        ],
    }),
    methods: {
        redirectLink(link) {
            window.open(link);
        },
        redirect() {
            window.$cookies.remove('isSustainable');
            this.$router.push('/form');
        },
        getCookie() {
            return window.$cookies.get('isSustainable');
        },
        // eslint-disable-next-line
        whichColor(category) {
            console.log(this.getCookie().category)
            if (this.getCookie().category == 0) {
                return "red lighten-4";
            } else {
                return "green lighten-4"
            }
        },
        // eslint-disable-next-line
        whichIcon(category) {
            if (this.getCookie().category == 0) {
                return "alert-circle";
            } else {
                return "check";
            }
        },
        // eslint-disable-next-line
        whichIconColor(category) {
            if (this.getCookie().category == 0) {
                return "error";
            } else {
                return "teal";
            }
        }
    },
    computed: {

    }
}


</script>