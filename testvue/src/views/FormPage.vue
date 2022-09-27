<template>

  <v-app>
    <v-card elevation="5" width="80%" class="mx-auto mt-5">
        <v-tabs
          v-model='tab'
          background-color="deep-purple accent-4"
          center-active
          dark >

          <!-- ############################################################# TAB 1 -->
        <v-tab ripple href='#tab-1' @click="setCurrentTab(1)"> Economical </v-tab>
          <v-tab-item value='tab-1'> 
            
            <v-card-text class="text-left font-weight-black my-5" v-show="currentTab == 1">

              <p> This is a question about commuting, how do you plan to commute to work?: </p>
              <!-- rows margin-y-axis-5, x-axis-2- -->
              <v-row class="my-5 mx-2">
                <v-btn-toggle
                  v-model="multipleQ1"
                  multiple>
                  <v-btn elevation="2" class="mx-2"> No </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably not </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably </v-btn>
                  <v-btn elevation="2" class="mx-2"> Yes </v-btn>
                </v-btn-toggle>
              </v-row>

              <p> This is Eco question two: </p>
              <v-row class="my-8 mx-2">
                <v-btn-toggle>
                  <v-btn elevation="2" class="mx-2"> No </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably not </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably </v-btn>
                  <v-btn elevation="2" class="mx-2"> Yes </v-btn>
                </v-btn-toggle>
              </v-row>

              <v-row class="mx-2">
                <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
                <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
              </v-row>

            </v-card-text>  
          </v-tab-item>
        <!-- ############################################################# TAB 1 -->
        

        <!-- ############################################################# TAB 2 -->     
        <v-tab ripple href='#tab-2' @click="setCurrentTab(2)"> Social </v-tab>
          <v-tab-item value='tab-2'> 
            <v-card-text class="text-left font-weight-black my-5" v-show="currentTab == 2">

              <p> This is a question about commuting, how do you plan to commute to work?: </p>
              <!-- rows margin-y-axis-5, x-axis-2- -->
              <v-row class="my-5 mx-2">
                <v-btn-toggle
                  v-model="multipleQ2"
                  multiple>
                  <v-btn elevation="2" class="mx-2"> No </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably not </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably </v-btn>
                  <v-btn elevation="2" class="mx-2"> Yes </v-btn>
                </v-btn-toggle>
              </v-row>

              <p> This is Eco question two: </p>
              <v-row class="my-8 mx-2">
                <v-btn-toggle>
                  <v-btn elevation="2" class="mx-2"> No </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably not </v-btn>
                  <v-btn elevation="2" class="mx-2"> Probably </v-btn>
                  <v-btn elevation="2" class="mx-2"> Yes </v-btn>
                </v-btn-toggle>
              </v-row>

              <v-row class="mx-2">
                <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
                <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
              </v-row>

            </v-card-text>  
        </v-tab-item>
        <!-- ############################################################# TAB 2 -->     
        

        <v-tab ripple href='#tab-3'> Economical </v-tab>
          <v-tab-item value='tab-3'> 
            <h1> test3 </h1>
            <v-row class="mx-2">
              <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
              <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
            </v-row>
          </v-tab-item>

        <v-tab ripple href='#tab-4'> Other </v-tab>
          <v-tab-item value='tab-4'> 
            <h1> test4 </h1>
            <v-row class="mx-2">
              <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
              <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
            </v-row>
          </v-tab-item>

      </v-tabs>

      <!-- Economical Questions -->

      <!-- <v-card-text class="text-left font-weight-black my-5" v-show="currentStep == 2">
        <p> This is Soc question one: </p>
        <p> This is Soc question two: </p>
      </v-card-text>

      <v-card-text class="text-left font-weight-black my-5" v-show="currentStep == 3">
        <p> This is Enc question one: </p>
        <p> This is Enc question two: </p>
      </v-card-text>

      <v-card-text class="text-left font-weight-black my-5" v-show="currentStep == 4">
        <p> This is Other question one: </p>
        <p> This is Other question two: </p>
      </v-card-text> -->

      <!-- 
      <v-card-text class="text-left font-weight-black my-5" v-show="currentStep == 1">
        <p> This is question one: </p>
        
        rows margin-y-axis-5, x-axis-2-
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
      </v-card-text> -->

    </v-card>
  </v-app>


</template>
  
  <script>
    export default {
      name: 'FormPage',
  
      data: () => ({
        tab: 'tab-1',
        multipleQ1: [],
        multipleQ2: [],
        currentTab: 1,
        value: 0,
        tickLabels: ['Terrible!', 'Bad', 'Okay', 'Good', 'Excellent!'],
      }),

      methods: {
        prevTab(){
          if(this.currentTab != 1){
            this.currentTab -= 1;
          }
          switch(this.currentTab){
            case 1: this.tab = 'tab-1'; break;
            case 2: this.tab = 'tab-2'; break;
            case 3: this.tab = 'tab-3'; break;
            case 4: this.tab = 'tab-4'; break;
          }
          console.log(this.currentTab);
        },
        nextTab(){
          if(this.currentTab != 4){
            this.currentTab += 1;
          }
          switch(this.currentTab){
            case 1: this.tab = 'tab-1'; break;
            case 2: this.tab = 'tab-2'; break;
            case 3: this.tab = 'tab-3'; break;
            case 4: this.tab = 'tab-4'; break;
          }
          console.log(this.currentTab);
        },
        setCurrentTab(tab){
          this.currentTab = tab;
        }
      }
    }
  </script>
  
<style>

</style>