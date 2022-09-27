<template>

  <v-card elevation="5" width="80%" class="mx-auto mt-5">
    <v-tabs
    v-model='tab'
    background-color="deep-purple accent-4"
    center-active
    dark>
    
    <!-- ############################################################# TAB 1 -->
    <v-tab ripple href='#tab-1' @click="setCurrentTab(1)"> Economical </v-tab>
    <v-tab-item value='tab-1'>
      
        <!-- Tab Content -->
        <v-card-text class="text-left font-weight-black my-5"
        v-show="currentTab == 1"
        v-for="(question, index) in ecoQuestions"
        :key="question.text">
            
        
        
        <v-row class="mx-auto">
          <v-col>
            <p> {{question.text}} </p>
          </v-col>
          <v-col >
            <v-icon large right>  mdi-progress-question </v-icon>
          </v-col>
        </v-row>
  
          <!-- Answer buttons -->
          <v-row class="my-5 mx-2">
              <v-btn-toggle v-model="listOfAnswer[index]" multiple >
                <v-btn elevation="2" class="mx-2" v-for="button in answerButton" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
              </v-btn-toggle>
            </v-row>
          </v-card-text>
  
          <!-- Prev and Next button -->
          <v-row class="my-5 mx-2">
            <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
            <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
          </v-row>
  
        </v-tab-item>


      <!-- ############################################################# TAB 2 -->
      <v-tab ripple href='#tab-2' @click="setCurrentTab(2)"> Social </v-tab>

      <v-tab-item value='tab-2'>

        <v-card-text class="text-left font-weight-black my-5"
          v-show="currentTab == 2"
          v-for="(question, index) in socQuestions"
          :key="question.text">

          <p> {{question.text}} </p>

          <!-- Answer buttons -->
          <v-row class="my-5 mx-2">
            <v-btn-toggle v-model="listOfAnswer[index]" multiple >
              <v-btn elevation="2" class="mx-2" v-for="button in answerButton" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
            </v-btn-toggle>
          </v-row>
        </v-card-text>

        <!-- Prev and Next button -->
        <v-row class="my-5 mx-2">
          <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev </v-btn>
          <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next </v-btn>
        </v-row>

      </v-tab-item>

      <!-- ############################################################# TAB 3 -->
      <v-tab ripple href='#tab-3'> Economical </v-tab>
      <v-tab-item value='tab-3'>
      </v-tab-item>

      <!-- ############################################################# TAB 4 -->
      <v-tab ripple href='#tab-4'> Other </v-tab>
      <v-tab-item value='tab-4'>
      </v-tab-item>

    <!-- End of tabs -->
    </v-tabs>

  <!-- End of Cad -->
  </v-card>

<!--
  <v-slider class="my-5"
    v-model="value"
    step="25"
    ticks="always"
    :tick-labels="tickLabels"
  > </v-slider>

  <v-col cols="12" sm="3" md="8" >
      <v-text-field label="Solo" solo>

      </v-text-field>
  </v-col> -->



</template>

  <script>
    export default {
      name: 'FormPage',

      data: () => ({
        // Used right now

        answerButton: [
          { text: 'No',           id: '1', toggle: false},
          { text: 'Probably not', id: '2', toggle: false },
          { text: 'Probably',     id: '3', toggle: false },
          { text: 'Yes',          id: '4', toggle: false },
        ],

        ecoQuestions: [
          { text: 'This is eco question 1?'},
          { text: 'This is an example of a very long eco question, how will the form handle this, no one knows. But one thing is for sure, it probably wont work as inteaded in the first try?'},
          { text: 'This is eco question 3?'},
          { text: 'This is eco question 4?'},
        ],

        socQuestions: [
          { text: 'This is soc question 1?'},
          { text: 'This is soc question 2?'},
          { text: 'This is soc question 3?'},
          { text: 'This is soc question 4?'},
        ],

        listOfAnswer: [],
        currentTab: 1,
        tab: 'tab-1',

        // Not used right now

        value: 0,
        tickLabels: ['Terrible!', 'Bad', 'Okay', 'Good', 'Excellent!'],
      }),

      methods: {

        prevTab(){
          if(this.currentTab != 1){
            this.currentTab -= 1;
          }
          this.switchCurrentTab();
        },

        nextTab(){
          if(this.currentTab != 4){
            this.currentTab += 1;
          }
          this.switchCurrentTab();
        },

        switchCurrentTab(){
          switch(this.currentTab){
            case 1: this.tab = 'tab-1'; break;
            case 2: this.tab = 'tab-2'; break;
            case 3: this.tab = 'tab-3'; break;
            case 4: this.tab = 'tab-4'; break;
          }
          console.log("Current Tab: " + this.currentTab);
        },

        setCurrentTab(tab){
          this.currentTab = tab;
        },

        debugLog(){
          // console.log(this.listOfAnswer);
        }
      }
    }
  </script>

<style>

</style>