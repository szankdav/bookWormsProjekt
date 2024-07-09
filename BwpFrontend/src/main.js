import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import 'bootstrap/dist/css/bootstrap.css'
import axios from 'axios'
import VueAxios from 'vue-axios'

const app = createApp(App)

app.use(router, axios, VueAxios)

app.provide('axios', app.config.globalProperties.axios)

app.mount('#app')
