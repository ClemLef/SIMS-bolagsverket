<template>
    <!-- Contains the application header and navigation drawer -->
    <div>
        <v-app-bar color="green darken-4">
            <v-app-bar-nav-icon class="white--text" @click="drawer = true"></v-app-bar-nav-icon>
            <v-spacer></v-spacer>
            <v-app-bar-title class="font-weight-bold white--text">
                Sustainability Barometer
            </v-app-bar-title>
        </v-app-bar>

        <v-navigation-drawer v-model="drawer" absolute temporary>
            <v-list nav dense class="mt-2">
                <v-list-item-group active-class="green--text lighten-4">
                    <v-list-item v-for="item in items" :key="item.title" link @click="redirect(item)">
                        <v-list-item-icon>
                            <v-icon>{{ item.icon }}</v-icon>
                        </v-list-item-icon>
                        <v-list-item-title class="body-2 text-left font-weight-medium">{{ item.title }}</v-list-item-title>
                    </v-list-item>
                </v-list-item-group>
            </v-list>
        </v-navigation-drawer>
    </div>
</template> 


<script>
export default {
    data() {
        return {
            drawer: false,
            // Items to be displayed on the navigation drawer
            items: [
                { title: 'Home', icon: 'mdi-home-circle-outline', path: '/' },
                { title: 'Sustainability Test', icon: 'mdi-leaf-circle-outline', path: '/form' },
                { title: 'Results', icon: 'mdi-gauge', path: '/results' },
                { title: 'Help', icon: 'mdi-help-circle-outline', path: '/info' },
            ],
        }
    },
    methods: {
        // Redirect to the corresponding page
        redirect(item) {
            // Check if the page is not the current page to prevent looping navigation
            if (this.$route.path != item.path) {
                this.$router.push(item.path)
            }
        },
    },
}
</script>