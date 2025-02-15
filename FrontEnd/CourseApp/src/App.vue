
<template>
      
      <Landinghead/>


        <LandingFooter/>
   
   
   
   <RouterView /> <!-- router çalışabilmesi için routerview komponentimizi geçmemiz gerekiyor (İlgili path te ilgili componentin çalışmasını sağlar)  -->
</template>
<script setup>
import Landinghead from './components/Landing/Header/Header.vue'
import LandingFooter from './components/Landing/Footer/LandingFooterComponent.vue'



</script>



<style scoped>
</style>
