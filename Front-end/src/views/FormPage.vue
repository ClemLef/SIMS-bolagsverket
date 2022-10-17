<template>
  <FormData 
    :tabData2="tabData2" 
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

        for(var i = 0; i < this.tabData2.length; i++){
          for(var j = 0; j < this.allQuestions.length; j++){

            var text = this.allQuestions[j].question;                     // text
            var info = this.allQuestions[j].help_information;   // subquestion group
            var category = this.allQuestions[j].category;                // 2002 / social
            var answerSet = this.allQuestions[j].set_question;          // answer set
            var hasSubQuestion = this.allQuestions[j].has_sub_questions; // has sub question, true or false
            var subQuestionGroup = this.allQuestions[j].show_subquestion_group;   // subquestion group
            var show = this.allQuestions[j].active;   // subquestion group
            
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
      }
    },

    created(){
      this.loadAnswerSets();
      this.loadAllQuestion();
      window.$cookies.remove('isSustainable');//to remove
    },  
    
    data: () => ({
      allQuestions: {},
      allAnswerSet: {},

      answerButtonSet_1: [],
      answerButtonSet_2: [],
      answerButtonSet_3: [],

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
      
    }),
  }
</script>