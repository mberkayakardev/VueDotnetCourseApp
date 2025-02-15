<template>
    <div class="card mb-3 ml-5" style="max-width: 540px;">
      <div class="row g-0">
        <div class="col-md-4 costuemcontainer">
          <img 
            :src="kurs.courseCoverImage || defaultResim" 
            class="img-fluid rounded-start center-image" 
            alt="Kurs Resmi"
          />
        </div>
        <div class="col-md-8">
          <div class="card-body">
            <h5 class="card-title text-center">{{ kurs.courseName }}</h5>
            <p class="card-text text-center">{{ kurs.courseDescription }}</p>
            <p class="card-text text-center">{{ kurs.coursePrice }} TL</p>

            
            <button 
              style="width: 100%;" 
              type="button" 
              class="btn btn-primary btn-lg btn-block"
              @click="detaySayfasinaGit"
            >
              Detaylar
            </button>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: "CourseCardİtem",
    props: {
      kurs: Object // ✅ `kurs` objesini prop olarak al
    },
    computed: {
      // ✅ Eğer kursun resmi yoksa default bir resim göster
      defaultResim() {
        return "https://upload.wikimedia.org/wikipedia/commons/b/b2/Bootstrap_logo.svg";
      }
    },
    methods: {
      detaySayfasinaGit() {
        // ✅ Kurs detay sayfasına yönlendirme
        this.$router.push(`/kurs/${this.kurs.id}`);
      }
    }
  };
  </script>
  
  <style>
  .costuemcontainer {
    display: flex;
    align-items: center;
    justify-content: center;
  }
  
  .center-image {
    max-width: 100%;
    height: auto;
  }
  </style>
  