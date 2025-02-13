import { createRouter, createWebHistory } from 'vue-router'
import LandingHome from "../components/Landing/Home/HomeMainComponent.vue"
import LandingAbout from "../components/Landing/About/AboutMainComponent.vue"
import SignIn from "../components/Landing/SignIn/SignIn.vue"


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: LandingHome,
    },
    {
      path: '/about',
      name: 'about',
      component: LandingAbout,
    },
    {
      path: '/signin',
      name: 'signin',
      component: SignIn,
    },
  ],
})

export default router
