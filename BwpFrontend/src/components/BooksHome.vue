<script setup>
import { onMounted, ref } from 'vue';
import { useGetBooks } from '@/composables/services/apiService';

const { books, error } = useGetBooks('https://localhost:7264/Books')

</script>

<template>
  <div class="container mt-5">
    <div class="row">
      <div class="col-12">
        <h1>Available books:</h1>
        <ul v-if="books">
          <li v-for="book in books">
          {{ book['id'] + '.' }}
          {{ book['title'] }}
        </li>
        </ul>
        <h1 v-else="error">Error while loading books...</h1>
      </div>
    </div>
  </div>
</template>

<style scoped>

</style>