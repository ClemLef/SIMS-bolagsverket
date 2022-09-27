import Vue from 'vue'
import VueRouter from 'vue-router'
import HomePage from '../views/HomePage.vue'
import FormPage from '../views/FormPage.vue'
import ResultsPage from '../views/ResultsPage.vue'
import HelpPage from '../views/HelpPage.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomePage
  },
  {
    path: '/form',
    name: 'form',
    component: FormPage
  },
  {
    path: '/results',
    name: 'results',
    component: ResultsPage
  },
  {
    path: '/help',
    name: 'help',
    component: HelpPage
  },
]

const router = new VueRouter({
  routes
})

export default router
