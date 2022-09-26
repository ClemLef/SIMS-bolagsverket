<template>

  <v-app>
    <v-card elevation="5" width="80%" class="mx-auto mt-5">
        <v-tabs
          background-color="deep-purple accent-4"
          center-active
          dark
        >
        <v-tab> Economical </v-tab>
        <v-tab> Social </v-tab>
        <v-tab> Enviromental</v-tab>
        <v-tab> Result </v-tab>
      </v-tabs>

      <v-card-text class="text-left font-weight-black my-5">
        <p> This is question one: </p>
        
        <!--rows margin-y-axis-5, x-axis-2--->
        <v-row class="my-5 mx-2">
          <v-btn elevation="2" class="mx-2"> No </v-btn>
          <v-btn elevation="2" class="mx-2"> Probably not </v-btn>
          <v-btn elevation="2" class="mx-2"> Probably </v-btn>
          <v-btn elevation="2" class="mx-2"> Yes </v-btn>
        </v-row>
        
        <p> This is question Two: </p>

        <v-slider class="my-5"
          v-model="value"
          step="25"
          ticks="always"
          :tick-labels="tickLabels"
        > </v-slider>

        <p> This is question Three: </p>

        <v-col cols="12" sm="3" md="8" >
            <v-text-field label="Solo" solo>

            </v-text-field>
          </v-col>

        <p> This is question Four: </p>
        
      </v-card-text>

    </v-card>
  </v-app>


</template>
  
  <script>
    export default {
      name: 'FormPage',
  
      data: () => ({
        value: 0,
        tickLabels: ['Terrible!', 'Bad', 'Okay', 'Good', 'Excellent!'],
      }),
    }
  </script>
  
<style>
    .input{
        
    }
</style>