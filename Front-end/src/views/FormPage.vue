<template>
  <FormData 
    :tabData="tabData" 
    :answerSets="answerSets"
    :formLoading="formLoading">
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
      
      // loads all tabs from db and puts them into tabData object
      async loadTabs(){
        const tabs = await FormAPI.getCategories();
        const allTabs = tabs.data;
  
        for(var i = 0; i < allTabs.length; i++){
  
          var index = i;
          var title = allTabs[i].name;  
  
          this.tabData.push({
            id: index,
            title: title,
            
            answers: [],
            questions: [],
            result: 0,
          })
        }
      },

      // loads all question from db and puts them into a tab inside of tabData object
      async loadAllQuestion() {
        
        this.formLoading = true;
        
        const questions = await FormAPI.getQuestions()
        .catch(error => { console.log("Could not load questions from Database: " + error) })
        .finally(() => {this.formLoading = false});
        
        const allQuestions = questions.data;
        
        // var questionCounter = 1;  // User Test purpose
        // var questionsToShow = 2;  // User Test purpose

        // Get every question for every tab and place the question into tab
        for(var i = 0; i < this.tabData.length; i++){
          for(var j = 0; j < allQuestions.length; j++){

            var text = allQuestions[j].set_question;                    
            var info = allQuestions[j].help_information;           
            var category = allQuestions[j].category;                
            var answerSet = allQuestions[j].answer_set;          
            var hasSubQuestion = allQuestions[j].has_sub_question; 
            var subQuestionGroup = allQuestions[j].sub_question_group;   
            var show = allQuestions[j].active; 
            
            if(category == [i]){

              if(this.tabData[i].questions.length < this.questionsToShow){ // User Test purpose, if tab contains more questions then limit, don't show more questions on this tab
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

                this.questionCounter++;            // User Test purpose
              }
            }
            
          }
          this.questionCounter = 0; // User Test purpose, reset questions counter for every new tab
        }
      },

      // loads all sets of answers and categorize them. 
      async loadAnswerSets(){
        const answerSets = await FormAPI.getAnswerSets();
        const allAnswerSets = answerSets.data;

        for(var i = 0; i < allAnswerSets.length; i++){

          // local variables for simplifying conditions s
          var text = allAnswerSets[i].set_name;   
          var group = allAnswerSets[i].set_group;   
          var value = allAnswerSets[i].set_value

          this.answerSets.push({
            text: text,
            group: group, 
            value: value,
          })         
        }

      }

    },

    created(){

      this.loadTabs();          // Load all tabs from DB through api into the tabData object    
      this.loadAllQuestion();   // Load all questions from DB through api into the tabData object   
      this.loadAnswerSets();    // Load all answers from DB trough api and assigns data to 3 diffrent set of answers

      window.$cookies.remove('isSustainable');//to remove
    },  
    
    data: () => ({

      formLoading: false,
      answerSets: [],
      questionCounter: 1,  // User Test purpose
      questionsToShow: 2,  // User Test purpose
      
      tabData:[

        /* This is an example of how the tabData object will be structured when all data from database has been loaded
        /* FormData.vue file works with this object to display all information correctly
        {
          id: 0,                            // Tab id
          title: 'Economical',              // Tab name
          answers: [],                      // List of all answers for all the question in the tab
          questions: [                      // List of all question for the tab
            {
              text: Question 1,             // Question in text 
              info: Definition for question // Extra definition for the question  
              show: true,                   // Show or hide question in form, subquestions are hidden at start
              showInfo: false,              // Show definition for question or not
              answerSet: 3,                 // Set of answers that will be used to answer the question, e.g Yes/NO is set 1
              hasSubQuestion: true,         // Specifies if the question has subquestions or not
              subQuestionGroup: 3,          // If there is a subquestion, assign a value to parent and child question for grouping purpose
              showSubQuestionList: [],      // List of answer for the parent question, if list contains "yes", subquestion will be shown
            }
          ],
          result: 0,
        },
        */
      ],   

    }), // End of data
  } //End of export

</script>