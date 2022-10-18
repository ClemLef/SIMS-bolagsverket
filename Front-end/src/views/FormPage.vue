<template>
  <FormData 
    :tabData="tabData" 
    :answerButtonSet_1="answerButtonSet_1" 
    :answerButtonSet_2="answerButtonSet_2"
    :answerButtonSet_3="answerButtonSet_3">
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
    
      //loads all question from db and puts them in this.allquestion list in data
      async loadAllQuestion() {

        const questions = await FormAPI.getQuestions();
        this.allQuestions = questions.data;

        for(var i = 0; i < this.tabData.length; i++){
          for(var j = 0; j < this.allQuestions.length; j++){

            var text = this.allQuestions[j].question;                     // text
            var info = this.allQuestions[j].help_information;   // subquestion group
            var category = this.allQuestions[j].category;                // 2002 / social
            var answerSet = this.allQuestions[j].set_question;          // answer set
            var hasSubQuestion = this.allQuestions[j].has_sub_questions; // has sub question, true or false
            var subQuestionGroup = this.allQuestions[j].show_subquestion_group;   // subquestion group
            var show = this.allQuestions[j].active;   // subquestion group
            
            if(category == [i]){
              this.tabData[i].questions.push({
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

      // loads all sets of answers and categorize them. 
      // IMPROVE THIS CODE PLZ MATTIAS
      async loadAnswerSets(){
        const answerSets = await FormAPI.getAnswerSets();
        this.allAnswerSets = answerSets.data;

        for(var i = 0; i < this.allAnswerSets.length; i++){

          // local variables for simplifying conditions s
          var text = this.allAnswerSets[i].set_name;   
          var group = this.allAnswerSets[i].set_group;   
          var value = this.allAnswerSets[i].set_value
          
          if(group == 1){
            this.answerButtonSet_1.push({
              text: text,
              group: group, 
              value: value,
            })
          }

          if(group == 2){
            this.answerButtonSet_2.push({
              text: text,
              group: group, 
              value: value,
            })
          }

          if(group == 3){
            this.answerButtonSet_3.push({
              text: text,
              group: group, 
              value: value,
            })
          }
          
        }
      },

      async loadTabs(){
        const tabs = await FormAPI.getCategories();
        this.allTabs = tabs.data;

        console.log(tabs.data);

        // console.log(this.allTabs.id);
        // console.log(this.allTabs.name);
        // console.log(this.allTabs.categorys_code);
      }

    },

    created(){
      // this.loadTabs();
      this.loadAnswerSets();
      this.loadAllQuestion();
      window.$cookies.remove('isSustainable');//to remove
    },  
    
    data: () => ({
      allQuestions: {},
      allAnswerSet: {},
      allTabs: {},

      answerButtonSet_1: [],
      answerButtonSet_2: [],
      answerButtonSet_3: [],

      tabData:[
        {
          id: 0,
          title: 'Economical',
          answers: [],
          questions: [],
          result: 0,
        },
        {
          id: 1,
          title: 'Social',
          answers: [],
          questions: [],
          result: 0,
        },
        {
          id: 2,
          title: 'Enviromental',
          answers: [],
          questions: [],
          result: 0,
        },
        {
          id: 3,
          title: 'Positive influence',
          answers: [],
          questions: [],
          result: 0,
        }
      ],
      
    }),
  }
</script>