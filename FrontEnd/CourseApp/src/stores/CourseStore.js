import { ref, computed } from 'vue'
import { defineStore } from 'pinia'
import axios from 'axios'


/// Course isminde bir store tanımladım. Export ile store u dışarı açacağım. hangi komponentete kullanılacaksa ilgili componente import edilecektir. global state management yapıyoruz 
export const useCourseStore = defineStore('Course', {
    /// Başlangıç değeri atıoyur
    state:()=> ({
        courseList : []

    }),
    actions:{
        async GetCourseList(){
            try
            {
                const response = await axios.get('https://localhost:7132/products')
                this.courseList = response.data;
                console.log("Kurs listesi yüklendi:", this.courseList);
            }
            catch{
                console.error("Veri çekme hatası:", error);
            }
            
        }
    }
  })
  