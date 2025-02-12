<template>
 <nav class="navbar navbar-expand-lg bg-primary" data-bs-theme="dark">
  <div class="container-fluid">
    <RouterLink to="/" class="navbar-brand">Kurs Uygulaması</RouterLink>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarColor01">
      <ul class="navbar-nav me-auto ml-10">
        <li class="nav-item">
            <RouterLink to="/" class="nav-link">Ana Sayfa</RouterLink>
        </li>
        <li class="nav-item ml-2">
            <RouterLink to="/about" class="nav-link">Hakkında</RouterLink>
        </li>
      </ul>
    </div>
  </div>
</nav> 
</template>


<script>

export default{
    name : 'LandingHeader',
    data(){
        return({
        })
    }
}




</script>
<style>




</style>