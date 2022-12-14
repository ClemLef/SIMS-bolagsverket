import Vue from 'vue'
import App from './App'
import vuetify from './plugins/vuetify'
import router from './router'
import VueCookies from 'vue-cookies'
import header from './components/AppHeader.vue'
import footer from './components/AppFooter.vue'
import {store} from './store/store.js'


Vue.config.productionTip = false

Vue.component('AppHeader', header)
Vue.component('AppFooter', footer)

new Vue({
  store: store,
  vuetify,
  router,
  VueCookies,
  render: h => h(App)
}).$mount('#app')
