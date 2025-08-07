import { createRouter, createWebHistory } from 'vue-router'
import LoginPage from '../pages/LoginPage.vue'
import ParametrosPage from '../pages/ParametrosPage.vue'
import DashboardPage from '../pages/DashboardPage.vue'

const routes = [
  { path: '/', component: LoginPage },
  { path: '/login', component: LoginPage },
  { path: '/parametros', component: ParametrosPage },
  { path: '/dashboard', component: DashboardPage }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
