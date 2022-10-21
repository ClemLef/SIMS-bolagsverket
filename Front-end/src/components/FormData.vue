<template>

    <div class="my-10">

        <!-- Card that contains all questions, answers and content of each page -->
        <v-card elevation="5" width="85%" class="mx-auto">

            <v-tabs dark background-color="green darken-4" centered fixed-tabs v-model="currentTab">
                <v-tabs-slider color="white"></v-tabs-slider>

                <v-tab @click="setCurrentTab(tab.id)" width="20%" v-for="tab in tabData" :key="tab.id"
                    class="font-weight-bold">
                    {{tab.title}}
                </v-tab>
            </v-tabs>

            <!-- Loop through all questions in all tabs, for displaying all questions on the correct tab -->
            <label v-for="(tab, tabIndex) in tabData" :key="tab[tabIndex]" v-show="currentTab == tab.id">
                <label v-for="(question, index) in tab.questions" :key="question[index]">

                    <!-- If current question has an subquestion, handle if sub-question should be shown or hidden -->
                    <label v-if="hasSubQuestion(question)">
                        {{showSubQuestion(question, tab.questions, index)}}
                    </label>

                    <!-- If question is shown display text, help button and answers buttons -->
                    <v-card-text v-show="question.show == true" class="text-left font-weight-regular text-body-1 mx-5">

                        <!-- First Row of content contains question text, help button for extra information and help information -->
                        <v-layout tab class="mx-auto mt-7">

                            <!-- Question text -->
                            <v-flex md8>
                                <p> {{question.text}} </p>
                            </v-flex>

                            <label v-if="hasQuestionInfo(question)">
                                <!-- Help button with icon to show extra information about the question when hovered -->
                                <v-flex md1>
                                    <v-tooltip right max-width="25%" color="grey darken-3">
                                        <template v-slot:activator="{ on, attrs }">
                                            <v-btn small icon class="ml-auto my-auto mr-3" v-bind="attrs" v-on="on">
                                                <v-icon large> mdi-help-circle-outline </v-icon>
                                            </v-btn>
                                        </template>
                                        <span class="font-weight-bold"> {{question.info}} </span>
                                    </v-tooltip>
                                </v-flex>

                            </label>

                            <!-- Card that displayes help text about the question -->
                            <v-flex md3 class="mx-2">
                                <v-card elevation="5" shaped v-if="question.showInfo">
                                    <v-card-text class="text--primary font-weight-black">
                                        <p> {{question.info}} </p>
                                    </v-card-text>
                                </v-card>
                            </v-flex>

                        </v-layout>

                        
                        <!-- Second row of content contains answer buttons -->
                        <v-flex class="mt-5 mr-10">
                            
                            
                            <label v-if="question.answerSet == 1 ">
                                <v-btn-toggle v-model="question.showSubQuestionList[index]">
                                    <label v-for="answer in getAnswerSet(question)" :key="answer.text">                
                                        <v-btn :value="answer.value" elevation="2" class="mx-2"> 
                                            {{answer.text}} 
                                        </v-btn>        
                                    </label>
                                </v-btn-toggle>
                            </label>

                            <label v-else>
                                <v-btn-toggle v-model="tab.answers[index]">
                                    <label v-for="answer in getAnswerSet(question)" :key="answer.text">
                                        
                                        <v-btn :value="answer.value" elevation="2" class="mx-2"> 
                                            {{answer.text}} 
                                        </v-btn>        
                                    </label>
                                </v-btn-toggle>
                            </label>
                                
                            <v-divider class="mt-10"></v-divider>
                        </v-flex>
                        
                        
                    </v-card-text>
                </label>
            </label>

            <!-- Prev and Next button, increment or decrement current tab counter -->
            <v-row class="mx-8 my-10">
                <v-btn v-show="currentTab != 0" class="mx-2 my-4" depressed color="primary" large @click="prevTab();">
                    <v-icon left> mdi-arrow-left </v-icon>
                    Prev
                </v-btn>
                
                <v-btn v-show="currentTab != tabData.length - 1" class="mx-2 my-4" depressed color="success" large @click="nextTab();">
                    Next
                    <v-icon right> mdi-arrow-right </v-icon>
                </v-btn>
                
                <v-btn v-show="currentTab == tabData.length - 1" class="mx-2 my-4" :loading="loading" depressed
                    color="accent" large @click="calcFormResult()"> Result
                    <v-icon right> mdi-form-select </v-icon>
                </v-btn>
                <AlertMessage v-show="errorSendingDataAI" />
            </v-row>
            
            
        </v-card>
        
    </div>

</template>

<script>
import axios from 'axios';
import AlertMessage from './AlertMessage.vue';


export default {
    props: {
        tabData: Array,
        answerSets: Array,
    },

    components: {
        AlertMessage,
    },

    data: () => ({
        currentTab: 0,
        loading: false,
        errorSendingDataAI: false,
    }),
    methods: {
        getAnswerSet(question){
            var answerSet = [];

            for(var i = 0; i < this.answerSets.length; i++){
                if(this.answerSets[i].group == question.answerSet){

                    answerSet.push({
                        text: this.answerSets[i].text,
                        value: this.answerSets[i].value                     
                    })
                }
            }
            return answerSet;
        },

        hasQuestionInfo(question) {
            if (question.info == null) {
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
                console.log("error", this.output)
                if (output.code == "ERR_NETWORK") {
                    this.errorSendingDataAI = true
                    this.loading = false;
                } else {
                    this.errorSendingDataAI = false;
                    this.$router.push("/results");
                }
            })()


        },
        prevTab() {
            if (this.currentTab != 0)
                this.currentTab -= 1;
        },
        nextTab() {
            if (this.currentTab != 3)
                this.currentTab += 1;
        },
        setCurrentTab(selectedTab) {
            this.currentTab = selectedTab;
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
            // eslint-disable-next-line
            const response = await axios.post("http://34.136.8.129:5000/post", result)
                .then(function (response) {
                    console.log(response);
                    window.$cookies.config("1d");
                    window.$cookies.set("isSustainable", response.data);
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