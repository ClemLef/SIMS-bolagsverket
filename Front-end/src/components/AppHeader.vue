<template>
    <div>
        <v-app-bar color="green lighten-2">
            <v-app-bar-nav-icon class="green--text text--darken-4" @click="drawer = true"></v-app-bar-nav-icon>
            <v-spacer></v-spacer>
            <v-app-bar-title class="font-weight-bold green--text text--darken-4">Sustainability Barometer
            </v-app-bar-title>
        </v-app-bar>

        <v-navigation-drawer v-model="drawer" absolute temporary>
            <v-list nav dense class="mt-2">
                <v-list-item-group v-model="group" active-class="green--text lighten-4">
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
            group: false,
            items: [
                { title: 'Home', icon: 'mdi-home-circle-outline', path: '/' },
                { title: 'Sustainability Test', icon: 'mdi-leaf-circle-outline', path: '/form' },
                { title: 'Results', icon: 'mdi-gauge', path: '/results' },
                { title: 'Help', icon: 'mdi-help-circle-outline', path: '/help' },
            ],
        }
    },
    methods: {
        redirect(item) {
            if (this.$route.path != item.path) {
                this.$router.push(item.path)
            }
        }
    }
}
</script>