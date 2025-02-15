<template>
    <div class="container pt-3">
        <div class="row">
          <CourseCard v-for="kurs in courseStore.courseList" :key="kurs.id" :kurs="kurs" 
            />


        </div>

    </div>
</template>


<script>

import { onMounted } from 'vue'; 
import CourseCard from "./CourseCardİtem.vue"
import {useCourseStore} from '@/stores/CourseStore.js'

export default {
    name: 'CoruseListsComponent',
    components: {
        CourseCard,
    },
    setup() {
        const courseStore = useCourseStore();

        // Sayfa yüklendiğinde kurs listesini getir
        onMounted(async () => {
            await courseStore.GetCourseList();
        });

        return { courseStore };
    }
};
</script>



<style>

.costuemcontainer {
  display: grid;
  place-items: center; /* Hem yatay hem dikeyde ortala */
}
.container img {
  max-width: 100%; /* Resmin container'ı aşmamasını sağlar */
  max-height: 100%; /* Resmin container'ı aşmamasını sağlar */
}

</style>