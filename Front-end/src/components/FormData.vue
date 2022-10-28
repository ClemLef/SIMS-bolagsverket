<template>

    <main>

        <!-- Card that contains all questions, answers and content of each page -->
        <v-card elevation="5" width="85%" class="mx-auto my-10">
            
            <div dark v-if="formLoading" class="my-15 black--text">
                <h1> Loading Form </h1>
                <v-progress-circular indeterminate large :size="100" class="my-10">
                </v-progress-circular>
            </div>
            
            <div v-else>
                <!-- Tabs -->
                <v-tabs dark background-color="green darken-4" centered fixed-tabs v-model="currentTab">
                    <v-tabs-slider color="white"></v-tabs-slider>
                    
                        <v-tab @click="setCurrentTab(tab.id)" width="20%" v-for="tab in tabData" :key="tab.id"
                        class="font-weight-bold">
                        {{tab.title}}
                    </v-tab>
                </v-tabs>
    
                <!-- All content below tabs inside of v-card -->
                <div class="text-left mx-5 font-weight-bold text-body-1"> 
                    
                    <!-- Help information uniq for each tab -->
                    <v-container v-for="(info, index) in tabHelpInfo" :key="info[index]" v-show="info.tabID == currentTab">  

                        <span class="my-10">
                            <h1 class="my-10 text-center"> 
                                {{info.headline}} 
                            </h1>     
                            <p class="font-weight-bold">
                                {{info.text}}
                            </p>                
                        </span>     

                    </v-container>
                    
                    <!-- <p class="font-weight-bold"> 
                        {{helpInfoSource}} 
                    </p>   -->
                    
                    <v-divider> </v-divider>
                    
                    <!-- Loop through all questions in all tabs, for displaying all questions on the correct tab -->
                    <div v-for="(tab, tabIndex) in tabData" :key="tab[tabIndex]" v-show="currentTab == tab.id">
                        <div v-for="(question, index) in tab.questions" :key="question[index]">
                            
                            <!-- If current question has an subquestion, handle if sub-question should be shown or hidden -->
                            <template v-if="hasSubQuestion(question)">
                                {{showSubQuestion(question, tab.questions, index)}}
                            </template>
                            
                            <!-- If question is shown display text, help button and answers buttons -->
                            <v-card-text v-show="question.show == true">
                                
                                <!-- First Row of content contains question text, help button for extra information and help information -->
                                <v-layout tab class="mx-auto mt-7">
                                    
                                    <!-- Question text -->
                                    <v-flex md8 class="text-subtitle-1 font-weight-medium">
                                        <p> {{question.text}} </p>
                                    </v-flex>
                                    
                                    <!-- Help button with icon to show extra information about the question when hovered -->
                                    <template v-if="hasQuestionInfo(question)">
                                        <v-flex md1>
                                            <v-tooltip right max-width="25%" color="blue-grey lighten-5">
                                                <template v-slot:activator="{ on, attrs }">
                                                    <p class="font-weight-bold"> info </p>
                                                    <v-btn small icon class="ml-auto my-auto mr-3" v-bind="attrs" v-on="on">
                                                        <v-icon color="black" large> mdi-help-circle-outline </v-icon>
                                                    </v-btn>
                                                </template>
                                                <span class="black--text font-weight-bold"> {{question.info}} </span>
                                            </v-tooltip>
                                        </v-flex>
                                        
                                    </template>
                                    
                                </v-layout>
                                
                                
                                <!-- Second row of content contains answer buttons -->
                                <v-flex class="mt-5">  
                                    
                                    <!-- If this question has subquestions, display yes or no button and send result of click to another v-model then a regular question -->
                                    <template v-if="hasSubQuestion(question)">
                                        <v-btn-toggle v-model="question.showSubQuestionList[index]" >
                                            <div v-for="answer in getAnswerSet(question)" :key="answer.text">
                                                <v-btn :value="answer.value" elevation="2" class="mx-2"> 
                                                    {{answer.text}} 
                                                </v-btn >                  
                                            </div>
                                        </v-btn-toggle>
                                    </template>
                                    
                                    <!-- If this question does not have subquestions, display set of answers -->
                                    <template v-else>
                                        <v-btn-toggle v-model="tab.answers[index]">
                                            <div v-for="answer in getAnswerSet(question)" :key="answer.text">
                                                <v-btn color="blue-grey lighten-5" :value="answer.value" elevation="2" class="mx-2 black--text"> 
                                                    {{answer.text}} 
                                                </v-btn >                  
                                            </div>
                                        </v-btn-toggle>
                                    </template>
                                    
                                    <v-divider class="mt-10"></v-divider>
                                </v-flex>
                                
                                
                            </v-card-text>
                        </div>

                    </div>
                    
                    <!-- Prev and Next button, increment or decrement current tab counter -->
                    <v-row class="mx-8 my-10">
                        <v-btn v-show="currentTab != 0" class="mx-2 my-4" depressed color="success" large @click="prevTab();">
                            <v-icon left> mdi-arrow-left </v-icon>
                            Prev
                        </v-btn>
                        
                        <v-btn v-show="currentTab != tabData.length - 1" class="mx-2 my-4" depressed color="primary" large @click="nextTab();">
                            Next
                            <v-icon right> mdi-arrow-right </v-icon>
                        </v-btn>
                        
                        <v-btn v-show="currentTab == tabData.length - 1" class="mx-2 my-4" :loading="loading" depressed
                        color="primary" large @click="calcFormResult()"> Result
                        <v-icon right> mdi-form-select </v-icon>
                        </v-btn>
                        <AlertMessage v-show="errorSendingDataAI" />
                    </v-row>
                
                </div> <!-- End of all content below tabs inside of v-card -->
            </div> <!-- End of v-card including tabs -->
        </v-card>
    </main>

</template>

<script>
import axios from 'axios';
import AlertMessage from './AlertMessage.vue';


export default {
    
    
    computed: {
        tabHelpInfo() {
            return this.$store.state.tabHelpInfo;
        },
        helpInfoSource() {
            return this.$store.state.helpInfoSource;
        }
    },

    props: {
        tabData: Array,
        answerSets: Array,
        formLoading: Boolean,
    },

    components: {
        AlertMessage,
    },

    data: () => ({
        currentTab: 0,
        loadingForm: false,
        loading: false,
        errorSendingDataAI: false,
    }),
    methods: {
        getAnswerSet(question) {
            var answerSet = [];

            for (var i = 0; i < this.answerSets.length; i++) {
                if (this.answerSets[i].group == question.answerSet) {

                    answerSet.push({
                        text: this.answerSets[i].text,
                        value: this.answerSets[i].value
                    })
                }
            }
            return answerSet;
        },

        hasQuestionInfo(question) {
            if (question.info.length == 0) {
                return false;
            }
            else {
                return true;
            }
        },
        hasSubQuestion(currentQuestion) {
            if (currentQuestion.hasSubQuestion == true)
                return true;
            else
                return false;
        },
        // Uses current question to find whats subquestions that belong to it, display or hides those subquestions
        showSubQuestion(currentQuestion, allQuestion, index) {
            var showSubQuestion = currentQuestion.showSubQuestionList[index];
            var subQuestionGroup = currentQuestion.subQuestionGroup;

            // console.log(currentQuestion.showSubQuestionList);
            // console.log(currentQuestion.subQuestionGroup);
            // // console.log(currentQuestion);
            // console.log("i: " + index)
            // console.log("aq: " + allQuestion[0])


            // Shows and hides subquestion depending on yes or no answer from parent question
            if (showSubQuestion != null) {
                for (var i = 0; i < allQuestion.length; i++) {
                    if (allQuestion[i].subQuestionGroup == subQuestionGroup) {
                        if (showSubQuestion == true) {
                            allQuestion[i].show = true;
                        }
                        else {
                            if (allQuestion[i].hasSubQuestion != true) {
                                allQuestion[i].show = false;
                            }
                        }
                    }
                }
            }
        },
        calcTabResult(tab) {
            var numberOfAnswers = tab.answers.length;
            var numberOfAnswersWithValue = 0;
            var tabResult = 0;
            if (numberOfAnswers > 0) { // add zero as the result of tab of no buttons are pressed
                for (var i = 0; i < numberOfAnswers; i++) {
                    if (tab.questions[i].hasSubQuestion) {
                        tabResult += 0;
                    }
                    else {
                        if (tab.answers[i] != null) { // Makes sure not to add 'NaN' to result if question is not answered
                            numberOfAnswersWithValue++;
                            tabResult += tab.answers[i];
                        }
                        console.log("tab: " + (tab.id + 1) + "     Q" + (i) + ": " + (tab.answers[i]));
                    }
                }
                var average = tabResult / numberOfAnswersWithValue;
                tab.result = average;
                console.log("tab: " + (tab.id + 1) + "     tabResult: " + tabResult);
                console.log("tab: " + (tab.id + 1) + "     average:     " + average);
                console.log(" ");
                console.log("tab: " + (tab.id + 1) + "     result: " + tab.result);
            }
        },
        calcFormResult() {
            var numberOfTabs = this.tabData.length;
            var result = [];
            for (var i = 0; i < numberOfTabs; i++) {
                this.calcTabResult(this.tabData[i]);
                result.push(this.tabData[i].result);
            }
            console.log(result); // Log final results
            this.loading = true;
            this.errorSendingDataAI = false;
            (async () => {
                var output = await this.send_data_AI(result);
                if (output.code == "ERR_NETWORK" || output.code == "ERR_BAD_RESPONSE") {
                    this.errorSendingDataAI = true
                    this.loading = false;
                } else {
                    this.errorSendingDataAI = false;
                    this.$router.push({ path: 'results', query: { code: output.data.result_code } })
                }
                this.$vuetify.goTo(0)
            })()


        },
        prevTab() {
            if (this.currentTab != 0){
                this.currentTab -= 1;
                this.$vuetify.goTo(0)
            }
        },
        nextTab() {
            if (this.currentTab != 3){
                this.currentTab += 1;
                this.$vuetify.goTo(0)
            }
        },
        setCurrentTab(selectedTab) {
            this.currentTab = selectedTab;
            this.$vuetify.goTo(0)
        },
        showInfo(question) {
            if (question.showInfo == true) {
                question.showInfo = false;
            }
            else {
                question.showInfo = true;
            }
        },
        debugFunction(debug) {
            console.log(debug);
        },

        async send_data_AI(result) {
            this.loading = true;
            const response = await axios.post("http://34.136.8.129:5000/post", result)
                .then(function (response) {
                    return response;
                })
                .catch(function (error) {
                    console.log(error);
                    return error;
                });
            return response;
        },
    },
}
</script>