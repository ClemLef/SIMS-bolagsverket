<template>
    <v-app>
        <AppHeader />
        <div id="app" class="flex-wrapper">
            <router-view />
        </div>
        <AppFooter />
    </v-app>
</template>

<style lang="scss">
#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    height: fit-content;
    background-image: url("./assets/home_background_blur.jpg");
    background-repeat: no-repeat;
    background-size: cover;
}

nav {
    padding: 30px;

    a {
        font-weight: bold;
        color: #2c3e50;

        &.router-link-exact-active {
            color: #42b983;
        }
    }
}

.flex-wrapper {
    display: flex;
    min-height: 90vh;
    flex-direction: column;
    justify-content: flex-start;
}
</style>
