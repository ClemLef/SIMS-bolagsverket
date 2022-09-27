<template>
    
      <v-btn
        elevation="2"
        @click="greet"
      >Button</v-btn>
  </template>

<script>
    export default {
      name: 'HomePage',
      data: () => ({
        drawer: false,
        group: null,
        
      }),
      methods: {
      greet() {
        this.$router.push('/form')
      }
    }
      
    }
  </script>