<template>

  <v-card elevation="5" width="85%" class="mx-auto my-8">

    <v-tabs
      background-color="green darken-4"
      dark
      fixed-tabs
      v-model='tab' 
    >

    <!-- ############################################################# TAB 1 -->
    <v-tab ripple href=#tab-1 @click="setCurrentTab(1)"> Economical </v-tab>
    <v-tab-item value=tab-1>

      <!-- Tab Content -->
      <v-card-text 
      class="text-left font-weight-black my-5 mx-5" 
      v-show="currentTab == 1"
      v-for="(question, index) in ecoQuestions"
      :key="question.text">
          
        <!-- Row 1 contains question text, help button for extra information and help information -->
        <v-layout row class="mx-auto my-5">
          
          <!-- Question text -->
          <v-flex md8 >
            <p> {{question.text}} </p>
          </v-flex>
          
          <!-- Help button for extra information about the question -->
          <v-flex md1>
            <v-btn-toggle>
              <v-btn fab small rounded @click="showInfo(question)">
                <v-icon large>  mdi-progress-question </v-icon> 
              </v-btn>
            </v-btn-toggle> 
          </v-flex>
    
            
          <!-- Help text about the question -->
          <v-flex md4 class="mx-5">
            <v-card elevation="5" shaped v-if="question.showInfo">
              <v-card-text class="text--primary font-weight-black">
                <p > {{question.info}} </p>
              </v-card-text>
            </v-card>
          </v-flex>

        </v-layout>
          
          <!-- Second row contains answer buttons -->
          <v-layout row class="mx-auto">

            <v-flex>
              <!-- Answer question have answer set 1, show buttons with option: No, Probably Not, Probably, Yes -->
              <v-btn-toggle v-model="listOfAnswer[index]" v-if="question.answerSet == 1">
                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonTextSet_1" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
              </v-btn-toggle>
    
              <!-- Answer question have answer set 2, show buttons with option: None, Very Little, Some, A lot -->
              <v-btn-toggle v-model="listOfAnswer[index]" v-if="question.answerSet == 2">
                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonTextSet_2" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
              </v-btn-toggle>
            </v-flex>

          </v-layout>
          
      </v-card-text>     
        
      <!-- Prev and Next button, increment or decrement current tab counter -->
      <v-row class="mx-8 my-15">
        <v-btn class="mx-2" depressed color="primary" large @click="prevTab"> Prev 
          <v-icon right> mdi-arrow-left </v-icon>
        </v-btn>

        <v-btn class="mx-2" depressed color="success" large @click="nextTab"> Next 
          <v-icon left> mdi-arrow-right </v-icon>
        </v-btn>

        <!-- kanske inte behöver v-show eftersom hela kortet endast visas med v-show=currenttab -->
        <v-btn v-show="currentTab == 1" class="mx-2" depressed color="accent" large @click="resultTab"> Result  
          <v-icon right> mdi-form-select </v-icon>
        </v-btn>
      </v-row>
      
    </v-tab-item>
        
        
    <!-- ############################################################# TAB 2 -->
    <v-tab ripple href='#tab-2' @click="setCurrentTab(2)"> Social </v-tab>
    <v-tab-item value='tab-2'>

      <!-- Tab Content -->
      <v-card-text 
      class="text-left font-weight-black my-5 mx-5" 
      v-show="currentTab == 2"
      v-for="(question, index) in socQuestions"
      :key="question.text">
          
        <!-- Row 1 contains question text, help button for extra information and help information -->
        <v-layout row class="mx-auto my-5">
          
          <!-- Question text -->
          <v-flex md8 >
            <p> {{question.text}} </p>
          </v-flex>
          
          <!-- Help button for extra information about the question -->
          <v-flex md1>
            <v-btn-toggle>
              <v-btn fab small rounded @click="showInfo(question)">
                <v-icon large>  mdi-progress-question </v-icon> 
              </v-btn>
            </v-btn-toggle> 
          </v-flex>
    
            
          <!-- Help text about the question -->
          <v-flex md4 class="mx-5">
            <v-card elevation="5" shaped v-if="question.showInfo">
              <v-card-text class="text--primary font-weight-black">
                <p > {{question.info}} </p>
              </v-card-text>
            </v-card>
          </v-flex>

        </v-layout>
          
          <!-- Second row contains answer buttons -->
          <v-layout row class="mx-auto">

            <v-flex>
              <!-- Answer question have answer set 1, show buttons with option: No, Probably Not, Probably, Yes -->
              <v-btn-toggle v-model="listOfAnswer[index]" multiple v-if="question.answerSet == 1">
                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonTextSet_1" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
              </v-btn-toggle>
    
              <!-- Answer question have answer set 2, show buttons with option: None, Very Little, Some, A lot -->
              <v-btn-toggle v-model="listOfAnswer[index]" multiple v-if="question.answerSet == 2">
                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonTextSet_2" :key="button.text" @click="debugLog"> {{button.text}} </v-btn>
              </v-btn-toggle>
            </v-flex>

          </v-layout>
          
      </v-card-text>     
        
      <!-- Prev and Next button, increment or decrement current tab counter -->
      <v-row class="mx-8 my-15">
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

  <!-- End of Card -->
  </v-card>

</template>

<script>
  export default {
    name: 'FormPage',

    data: () => ({
      // Used right now

      
      answerButtonTextSet_1: [
        { text: 'No'          },
        { text: 'Probably not'},
        { text: 'Probably'    },
        { text: 'Yes'         },
      ],

      answerButtonTextSet_2: [
        { text: 'None'       },
        { text: 'Very Little'},
        { text: 'Some'       },
        { text: 'A lot'      },
      ],

      // Here is the group of question with help info that will be shown in the Economical tab
      ecoQuestions: [
        {text: 'Will responsible purchasing policies be used within your business ?',
        info: 'this is test info for eco question 1', 
        showInfo: false,
        answerSet: 1},
        
        {text: 'Do you plan to use Fskattsedel for your business ?', 
        info: 'this is test info for eco question 2', 
        showInfo: false,
        answerSet: 1},

        {text: 'Is it likely for your business to expand in the next few years? ?', 
        info: 'here is an example of a very long help description, how will the form handle this, no one knows. But one thing is for sure, it probably wont work as inteaded on the first try?', 
        showInfo: false,
        answerSet: 1},

        {text:'Would your business idea help generate profit for other companies ?', 
        info: 'this is test info for eco question 4', 
        showInfo: false,
        answerSet: 1},

        {text:'Is it possible for the business to be developped without additional investments and infrastructure ?', 
        info: 'this is test info for eco question 5', 
        showInfo: false,
        answerSet: 1},
        
        {text:'Are the produced services or goods affordable for the targeted customer ?', 
        info: 'this is test info for eco question 6', 
        showInfo: false,
        answerSet: 1},
        
        {text:'How many existing competing market solutions would you estimate exist ?', 
        info: 'this is test info for eco question 7', 
        showInfo: false,
        answerSet: 2},

        {text:'How much energy do you estimate your business will use ?', 
        info: 'this is test info for eco question 8', 
        showInfo: false,
        answerSet: 2},
        
        {text:'Do you plan to use green energy for most of the energy consumption ?', 
        info: 'this is test info for eco question 9', 
        showInfo: false,
        answerSet: 1},
        
        {text:'How much do you plan to invest to make your business more green?', 
        info: 'this is test info for eco question 10', 
        showInfo: false,
        answerSet: 2},
        
        {text:'Is it ahead of the technology compared to existing market solutions?', 
        info: 'this is test info for eco question 11', 
        showInfo: false,
        answerSet: 1},

        {text:'By changing your processes to be more ecological, would your company still be able to satisfy customer needs?', 
        info: 'this is test info for eco question 12', 
        showInfo: false,
        answerSet: 1},
      ],
      
      // Here is the group of question with help info that will be shown in the Social tab
      socQuestions: [
        {text: 'Are there any measures taken to improve working conditions ? example: Work from home, schedule, workload..',
        info: 'this is test info for soc question 1', 
        showInfo: false,
        answerSet: 2},
        
        {text: 'Are there any measures taken to improve safety in the work environment ?', 
        info: 'this is test info for soc question 2', 
        showInfo: false,
        answerSet: 2},
      ],
      
      // tabs:[
      //   { title: 'Economical', href: '#tab1', id:1, value:'tab-1', question: this.ecoQuestions},
      //   { title: 'Social', href: '#tab2', id:2, value:'tab-2', question: this.socQuestions},
      //   // { title: 'Ecological', href: '#tab1', id:2, value:'tab-3', question: ecoQuestions},
      // ],
      
      
      listOfAnswer: [],
      currentTab: 1,
      tab: 'tab-1',
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

      resultTab(){
        this.$router.push('/results')
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

      showInfo(question){
        if(question.showInfo == true){
          question.showInfo = false;
        } else{
          question.showInfo = true;
        }
      },

      debugLog(){
        // console.log(this.listOfAnswer);
      }
    }
  }
</script>