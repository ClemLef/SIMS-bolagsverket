<template>
  <FormData 
    :tabData="tabData" 
    :answerTextSet_1="answerTextSet_1" 
    :answerTextSet_2="answerTextSet_2"
    :answerTextSet_3="answerTextSet_3"
    :questionsList="questionsList">
  </FormData>
</template>


<script>

  import FormData from '../components/FormData.vue'  
  import FormAPI from '../controller/FormAPI.js'

  export default {
    
    components :{
      FormData
    },
    
    name: 'FormPage',

    methods: {
      
      async loadQuestion() {
        const questions = await FormAPI.getQuestion();
        console.log(questions.data);
        this.questionsList = questions.data;
      },

    },

    created(){
      this.loadQuestion();
    },  
    
    data: () => ({

      questionsList: {},

      answerTextSet_1: [
        { text: 'No' },
        { text: 'Yes'  },
      ],


      answerTextSet_2: [
        { text: 'No'          },
        { text: 'Probably not'},
        { text: 'Probably'    },
        { text: 'Yes'         },
      ],


      answerTextSet_3: [
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
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            //Main question
            {  
              text: 'Main question 1 ?', 
              info: 'test info for eco question 2', 
              showInfo: false,
              answerSet: 1,
              show: true,

              hasSubQuestion: true,
              subQuestionGroup: 1,
              showSubQuestionList: [],
            },
            //Sub question
            {
              text: 'sub question 1 ?',
              info: 'test info for eco question 1', 
              showInfo: false,
              subQuestionGroup: 1,
              answerSet: 2,
              showSubQuestionList: [],
              show: false      
            },
            //Main question
            {  
              text: 'Main question 2 ?', 
              info: 'test info for eco question 2', 
              showInfo: false,
              answerSet: 1,
              show: true,

              hasSubQuestion: true,
              subQuestionGroup: 2,
              showSubQuestionList: [],
            },
            //Sub question
            {
              text: 'sub question 2 ?',
              info: 'test info for eco question 1', 
              showInfo: false,
              subQuestionGroup: 2,
              answerSet: 2,
              showSubQuestionList: [],
              show: false      
            },


          ]
        },
        {
          id: 2,
          title: 'Social',
          answerList: [],
          result: 0,
          questions: [
            //Main question
            {  
              text: 'Main question 3 ?', 
              info: 'test info for eco question 2', 
              showInfo: false,
              answerSet: 1,
              show: true,

              hasSubQuestion: true,
              subQuestionGroup: 3,
              showSubQuestionList: [],
            },
            //Sub question
            {
              text: 'sub question 3 ?',
              info: 'test info for eco question 1', 
              showInfo: false,
              subQuestionGroup: 3,
              answerSet: 2,
              showSubQuestionList: [],
              show: false      
            },
            {
              text: 'Are there any measures taken to improve working conditions ? example: Work from home, schedule, workload..',
              info: 'test info for soc question 1', 
              showInfo: false,
              show: true,
              answerSet: 2
            },
            { 
              text: 'Are there any measures taken to improve safety in the work environment ?', 
              info: 'test info for soc question 2', 
              showInfo: false,
              show: true,
              answerSet: 2
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
              show: true,
              answerSet: 2
            },
            { 
              text: 'Are fossil fuels planned to be used in some parts of the business process?', 
              info: 'test info for env question 2', 
              showInfo: false,
              show: true,
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
              show: true,
              answerSet: 2
            },
            { 
              text: 'Do you plan to be a member in a union who work in order to promote sustainibility work?', 
              info: 'test info for other question 2', 
              showInfo: false,
              show: true,
              answerSet: 2
            },
            
          ]
        },
      ],
      
    }),
  }
</script>