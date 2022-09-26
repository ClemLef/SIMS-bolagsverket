import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify'
import router from './router'
import header from './components/AppHeader.vue'

Vue.config.productionTip = false

Vue.component('AppHeader', header)

new Vue({
  vuetify,
  router,
  render: h => h(App)
}).$mount('#app')
