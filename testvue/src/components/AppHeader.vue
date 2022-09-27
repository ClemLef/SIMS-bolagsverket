<template>
    <div>
        <v-app-bar
            color="blue">
            <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
            <v-spacer></v-spacer>
            <v-app-bar-title>Sustainability Barometer</v-app-bar-title>
        </v-app-bar>

        <v-navigation-drawer
        v-model="drawer"
        absolute
        temporary
        >
            <v-list-item>

            <v-list-item-content>
                <v-list-item-title>Menu</v-list-item-title>
            </v-list-item-content>
            </v-list-item>

            <v-divider></v-divider>

            <v-list dense>
            <v-list-item
                v-for="item in items"
                :key="item.title"
                link
                @click="redirect(item)"
            >
                <v-list-item-icon>
                <v-icon>{{ item.icon }}</v-icon>
                </v-list-item-icon>

                <v-list-item-content>
                <v-list-item-title>{{ item.title }}</v-list-item-title>
                </v-list-item-content>
            </v-list-item>
            </v-list>
        </v-navigation-drawer>
    </div>
</template> 

<script>
    export default {
        data () {
            return {
                drawer: null,
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