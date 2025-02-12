
<template>
        <Landinghead/>


      
      <RouterView /> <!-- router çalışabilmesi için routerview komponentimizi geçmemiz gerekiyor (İlgili path te ilgili componentin çalışmasını sağlar)  -->
</template>
<script setup>
import Landinghead from './components/Landing/Header/Header.vue'


</script>



<style scoped>
</style>
