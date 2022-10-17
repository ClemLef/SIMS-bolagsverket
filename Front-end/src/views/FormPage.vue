<template>
  <FormData 
    :tabData2="tabData2" 
    :answerTextSet_1="answerTextSet_1" 
    :answerTextSet_2="answerTextSet_2"
    :answerTextSet_3="answerTextSet_3"
    :answerSets="answerSets">
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
    
      //loads one question from db and puts it in this.allquestion list in data
      async loadQuestion() {
        const questions = await FormAPI.getQuestion();
        this.questionsList = questions.data;
        // console.log(this.questionsList.id);
      },
      //loads all question from db and puts them in this.allquestion list in data
      async loadAllQuestion() {
        const questions = await FormAPI.getQuestions();
        this.allQuestionsList = questions.data;
        for(var i = 0; i < this.tabData2.length; i++){
          for(var j = 0; j < this.allQuestionsList.length; j++){
            // logging for testing each result
            // console.log(this.allQuestionsList[i].question);      // text
            // console.log(this.allQuestionsList[i].category);      // 2002 / social
            // console.log(this.allQuestionsList[i].set_categorys); // answer set
            // console.log(this.allQuestionsList[i].show_sub_category); // has set category, true or false
            // console.log(this.allQuestionsList[i].sub_categorys); // subquestion group
            // local variables for simplifying conditions 
            var text = this.allQuestionsList[j].question;                     // text
            var info = this.allQuestionsList[j].help_information;   // subquestion group
            var category = this.allQuestionsList[j].category;                // 2002 / social
            var answerSet = this.allQuestionsList[j].set_question;          // answer set
            var hasSubQuestion = this.allQuestionsList[j].has_sub_questions; // has sub question, true or false
            var subQuestionGroup = this.allQuestionsList[j].show_subquestion_group;   // subquestion group
            var show = this.allQuestionsList[j].active;   // subquestion group
            
            if(category == [i]){
              this.tabData2[i].questions.push({
                text: text,
                info: info, 
                show: show,
                showInfo: false,
                answerSet: answerSet,
                hasSubQuestion: hasSubQuestion,
                subQuestionGroup: subQuestionGroup,
                showSubQuestionList: [],
              })
            }
            
          }
        }
      },
      // TRY TO SHOW ANSWERS IN FORMDATA, THEY ARE LOADED, BUT IN A NEW WAY THAN PREVIOUS METHODS
      async loadAnswerSets(){
        const answerSets = await FormAPI.getAnswerSets();
        this.answerSetList = answerSets.data;
        // console.log(this.answerSetList);
        // console.log(this.answerSetList.length);
        for(var i = 0; i < this.answerSetList.length; i++){
            // local variables for simplifying conditions 
            var text = this.answerSetList[i].question;            // text
            var group = this.answerSetList[i].help_information;   // subquestion group
          if(group == i){
            this.answerSets.push({
              text: text,
              group: group
            })
          }
        }
      }
    },
    created(){
      // this.loadQuestion();
      this.loadAnswerSets();
      this.loadAllQuestion();
      window.$cookies.remove('isSustainable');//to remove
    },  
    
    data: () => ({
      allQuestionsList: {},
      answerSetList: {},
      answerSets: [], 
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
      tabData2:[
        {
          id: 0,
          title: 'Economical',
          answerList: [],
          questions: [],
          result: 0,
        },
        {
          id: 1,
          title: 'Social',
          answerList: [],
          questions: [],
          result: 0,
        },
        {
          id: 2,
          title: 'Enviromental',
          answerList: [],
          questions: [],
          result: 0,
        },
        {
          id: 3,
          title: 'Positive influence',
          answerList: [],
          questions: [],
          result: 0,
        }
      ],
      tabData: [
        {
          id: 1,
          title: 'Economical',
          answerList: [],
          result: 0,
          questions: [
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
            },
            { 
              text: '',
              info: '', 
              showInfo: false,
              answerSet: 2,
              showSubQuestionList: [],
              show: true
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