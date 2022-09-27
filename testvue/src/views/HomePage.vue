<template>
  <v-parallax dark src="../assets/home_background.jpg">
    <v-row align="center" justify="center">
      <v-col class="text-center" cols="12">
        <h1 class="text-h1 font-weight-thin mb-4">
          Welcome
        </h1>
        <h4 class="subheading mb-4"> Welcome to the Sustainability Barometer </h4>
        <h3 class="text-md-h4">This website will let you assess the sustainability of your business idea.</h3>
        <v-btn
          color="primary"
          elevation="6"
          large
          rounded
          x-large
          class="text-h4 font-weight-bold ma-10"
          @click="redirect"
        > Take the test now !</v-btn>
      </v-col>
    </v-row>
  </v-parallax>
</template>


<script>
export default {
  name: 'HomePage',
  data: () => ({
    drawer: false,
    group: null,
  }),
  methods: {
    redirect(){
      this.$router.push('/form')
    }
  },
}
</script>