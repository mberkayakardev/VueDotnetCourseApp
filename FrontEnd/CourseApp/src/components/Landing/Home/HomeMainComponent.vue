<template>
   <CoruseLists/>
</template>
   
   
   <script>

   import CoruseLists from './CoruseListsComponent.vue'


   export default{
       name : 'HomeMainComponent',
       components:{
        CoruseLists,
       },
       data(){
           return({
               name:'berkayakar'
           })
       }
       
   }
 
   
   </script>
   <style>
   
   
   
   
   </style>