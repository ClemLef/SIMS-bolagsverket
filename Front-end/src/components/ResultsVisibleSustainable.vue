<template>
    <v-expansion-panel-content class="mt-5">
        Your answers show that your business idea is sustainable for the social part.
        <br/>You can find additional ressources here :
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
    },
    
}
</script>