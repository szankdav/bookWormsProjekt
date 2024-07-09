import { ref } from "vue";
import axios from 'axios';

export function useGetBooks(url) {
    const books = ref([])
    const error = ref(null)

    axios({
        method: 'GET',
        url: url,
        headers: {
            'Access-Control-Allow-Origin': '*',
            "Accept": 'application-json',
        }
    })
    .then(res => {
        for (let i = 0; i < res.data.length; i++) {
            books.value.push(res.data[i])
        }
    })
    .catch(err => error.value = err)

    return { books, error }
}