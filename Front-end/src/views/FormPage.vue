<template>
  <FormData 
    :tabData="tabData" 
    :answerTextSet_1="answerTextSet_1" 
    :answerTextSet_2="answerTextSet_2">
  </FormData>
</template>


<script>

  
  // Gets formdata from file
  import FormData from '../components/FormData.vue'
  

  export default {

    //My components
    components :{
      FormData
    },

    name: 'FormPage',
    // url: 'http://35.184.240.64/api/questions',

    methods: {
        // retrieveData(){
        //   console.log(this.url)
        // }   
        

      // getResult(){

      //   for(const answerList in this.tabData){
      //     // console.log(answerList.toggle);
      //     console.log("this.toggle.length: " + answerList.length);
      //   }
      // }
      // retrieveData(){
      //   console.log(this.url)
      // }   
    },

    data: () => ({
    
        postId: null,
      // Used right now
      answerTextSet_1: [
        { text: 'No'          },
        { text: 'Probably not'},
        { text: 'Probably'    },
        { text: 'Yes'         },
      ],

      answerTextSet_2: [
        { text: 'None'       },
        { text: 'Very Little'},
        { text: 'Some'       },
        { text: 'A lot'      },
      ],

      tabData: [
        {
          id: 1,
          title: 'Economical',
          answerList: [],
          result: 0,
          questions: [
            {
              text: 'Will responsible purchasing policies be used within your business ?',
              info: 'test info for eco question 1', 
              showInfo: false,
              answerSet: 1
            },
            {  
              text: 'Do you plan to use Fskattsedel for your business ?', 
              info: 'test info for eco question 2', 
              showInfo: false,
              answerSet: 1
            },

          ]
        },
        {
          id: 2,
          title: 'Social',
          answerList: [],
          result: 0,
          questions: [
            
            {
              text: 'Are there any measures taken to improve working conditions ? example: Work from home, schedule, workload..',
              info: 'test info for soc question 1', 
              showInfo: false,
              answerSet: 1
            },
            { 
              text: 'Are there any measures taken to improve safety in the work environment ?', 
              info: 'test info for soc question 2', 
              showInfo: false,
              answerSet: 1
            },
            
          ]
        },
        {
          id: 3,
          title: 'Enviromental',
          answerList: [],
          result: 0,
          questions: [
            
            {
              text: 'Is the process going to use extracted materials (metal, coal, oil)?',
              info: 'test info for env question 1', 
              showInfo: false,
              answerSet: 1
            },
            { 
              text: 'Are fossil fuels planned to be used in some parts of the business process?', 
              info: 'test info for env question 2', 
              showInfo: false,
              answerSet: 2
            },
            
          ]
        },
        {
          id: 4,
          title: 'Influence',
          answerList: [],
          result: 0,
          questions: [      
            {
              text: 'Do you plan to cooperate with other entepreneurs or companies with assignments regarding sustainibility?',
              info: 'test info for other question 1', 
              showInfo: false,
              answerSet: 1
            },
            { 
              text: 'Do you plan to be a member in a union who work in order to promote sustainibility work?', 
              info: 'test info for other question 2', 
              showInfo: false,
              answerSet: 1
            },
            
          ]
        },
      ],
      
    }),
  }
</script>