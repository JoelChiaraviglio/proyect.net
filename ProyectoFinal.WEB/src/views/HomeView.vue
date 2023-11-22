<script setup lang="ts">

import {ref, onMounted} from 'vue';

// import Card from 'primevue/card'
import DataTable from 'primevue/datatable';
import Column from 'primevue/column';

let candidateList = ref([])


const getCandidateList = async () => {
var response = await fetch('https://localhost:7174/api/candidates')
const data = await response.json()
candidateList.value = data.candidateList
}



onMounted(async () => {
  await getCandidateList();
})

</script>

<template>
    <div class="grid">
      <div class="col-12">
          <DataTable :value="candidateList" >
            <Column field="id" header="#"></Column>
            <Column field="firstName" header="Nombre"></Column>
            <Column field="lastName" header="Apellido"></Column>

          </DataTable>

      </div>
    </div>
</template>

