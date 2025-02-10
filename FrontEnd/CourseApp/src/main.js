import 'vuetify/styles' /// vuetify için
import './assets/main.css'
import 'vue-toast-notification/dist/theme-bootstrap.css'; /// Toast Notification 


import { createApp } from 'vue'
import { createPinia } from 'pinia'
import { createVuetify } from 'vuetify' ///vuetify için
import * as components from 'vuetify/components' ///vuetify için
import * as directives from 'vuetify/directives' ///vuetify için
import ToastPlugin from 'vue-toast-notification'; /// Toast Notificatio niçin 
import App from './App.vue'
import router from './router'

const vuetify = createVuetify({   ///vuetify için
    components,
    directives,
  })
  


  // Import one of the available themes
  //import 'vue-toast-notification/dist/theme-default.css';
  




const app = createApp(App)

app.use(createPinia())
app.use(vuetify) ///vuetify için
app.use(router)
app.use(ToastPlugin); /// Toast Notification 


app.mount('#app')







