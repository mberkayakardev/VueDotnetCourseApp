<template>

<div class="container" id="footer">
  <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
    <p class="col-md-4 mb-0 text-muted">© 2024 Akar Bilişim</p>
    <a href="/" class="col-md-4 d-flex align-items-center justify-content-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none">
      <svg class="bi me-2" width="40" height="32"><use xlink:href="#bootstrap"></use></svg>
    </a>
    <ul class="nav col-md-4 justify-content-end">
      <li class="nav-item">
        <RouterLink to="/" class="nav-link px-2 text-muted">Ana Sayfa</RouterLink></li>
      <li class="nav-item">
        <RouterLink to="/about" class="nav-link px-2 text-muted">Hakkında</RouterLink>
    </li>
    </ul>
  </footer>
</div>
</template>


<script>

export default{
    name:"LandingFooterComponent"
}


</script>
<style>

#footer {
    position: absolute;
    left: 50%;
    bottom: 0px;
    transform: translateX(-50%);
} 
</style>