<template>
  <FormData :content="tabData"> </FormData>
</template>

<script>
  // Gets formdata from file
  import FormData from '../components/FormData.vue'

  export default {

    //My components
    components :{
      FormData
    },

    name: 'FormPage2',

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
      // ecoQuestions: [
      //   {text: 'Will responsible purchasing policies be used within your business ?',
      //   info: 'this is test info for eco question 1', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text: 'Do you plan to use Fskattsedel for your business ?', 
      //   info: 'this is test info for eco question 2', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text: 'Is it likely for your business to expand in the next few years? ?', 
      //   info: 'here is an example of a very long help description, how will the form handle this, no one knows. But one thing is for sure, it probably wont work as inteaded on the first try?', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'Would your business idea help generate profit for other companies ?', 
      //   info: 'this is test info for eco question 4', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'Is it possible for the business to be developped without additional investments and infrastructure ?', 
      //   info: 'this is test info for eco question 5', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'Are the produced services or goods affordable for the targeted customer ?', 
      //   info: 'this is test info for eco question 6', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'How many existing competing market solutions would you estimate exist ?', 
      //   info: 'this is test info for eco question 7', 
      //   showInfo: false,
      //   answerSet: 2},

      //   {text:'How much energy do you estimate your business will use ?', 
      //   info: 'this is test info for eco question 8', 
      //   showInfo: false,
      //   answerSet: 2},
        
      //   {text:'Do you plan to use green energy for most of the energy consumption ?', 
      //   info: 'this is test info for eco question 9', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'How much do you plan to invest to make your business more green?', 
      //   info: 'this is test info for eco question 10', 
      //   showInfo: false,
      //   answerSet: 2},
        
      //   {text:'Is it ahead of the technology compared to existing market solutions?', 
      //   info: 'this is test info for eco question 11', 
      //   showInfo: false,
      //   answerSet: 1},
        
      //   {text:'By changing your processes to be more ecological, would your company still be able to satisfy customer needs?', 
      //   info: 'this is test info for eco question 12', 
      //   showInfo: false,
      //   answerSet: 1},
      // ],
      
      // Here is the group of question with help info that will be shown in the Social tab
      // socQuestions: [
      //   {text: 'Are there any measures taken to improve working conditions ? example: Work from home, schedule, workload..',
      //   info: 'this is test info for soc question 1', 
      //   showInfo: false,
      //   answerSet: 2},
        
      //   {text: 'Are there any measures taken to improve safety in the work environment ?', 
      //   info: 'this is test info for soc question 2', 
      //   showInfo: false,
      //   answerSet: 2},
      // ],

      tabData: [
        {
          text: 'Economical',
          id: 1,
          content: 'content1',
          ecoQuestions: [
            {
              text: 'hello',
              info: "testinfo",
              showinfo: false,
              answerSet: 2,
            }
          ]
          // list: this.socQuestions
        },
        {
          title: 'Social',
          id: 2,
          content: "content2"
        },
        {
          title: 'Enviromental',
          id: 3,
          content: "content3"
        },
        {
          title: 'Other',
          id: 4,
          content: "content4"
        },
      ],

      questionData: [
        {
          text: 'Are there any measures taken to improve working conditions ? example: Work from home, schedule, workload..',
          info: 'this is test info for soc question 1', 
          showInfo: false,
          answerSet: 2},
        {
          title: 'Social',
          id: 2,
          content: "content2"
        },
        {
          title: 'Enviromental',
          id: 3,
          content: "content3"
        },
        {
          title: 'Other',
          id: 4,
          content: "content4"
        },
      ],
      
      listOfAnswer: [],
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