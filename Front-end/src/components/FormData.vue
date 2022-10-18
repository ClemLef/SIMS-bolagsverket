<template>

    <div class="my-10">

        <!-- Card that contains all questions, answers and content of each page -->
        <!-- Create Page buttons dynamically -->
        <v-btn @click="setCurrentTab(tab.id)" large elevation="3" width="20%" class="mt-10 white--text"
            color="green darken-4" :class="{'mb-1' : currentTab == tab.id}" v-for="tab in tabData2" :key="tab.id">
            {{tab.title}}
        </v-btn>

        <v-card elevation="5" width="85%" class="mx-auto">

            <!-- Showing correct page content /-->
            <div v-for="(tab, tabIndex) in tabData2" :key="tab[tabIndex]" v-show="currentTab == tab.id">

                <!-- Retrieving question object from correct page, then displaying question with corresponding answer options and help text -->
                <v-card-text v-for="(question, index) in tab.questions" :key="question[index]"
                    class="text-left font-weight-black mx-5">

                    <label v-show="question.show == true">

                        <label v-if="hasSubQuestion(question)">
                            {{showSubQuestion(question, tab.questions, index)}}
                        </label>

                        <!-- First Row of content contains question text, help button for extra information and help information -->
                        <v-layout tab class="mx-auto my-5">
                            <!-- Question text -->
                            <v-flex md9>
                                <p> {{question.text}} </p>
                            </v-flex>

                            <!-- Help button with icon to show extra information about the question when pressed -->
                            <v-flex md1>
                                <v-btn-toggle>
                                    <v-btn fab small rounded @click="showInfo(question)">
                                        <v-icon large> mdi-progress-question </v-icon>
                                    </v-btn>
                                </v-btn-toggle>
                            </v-flex>

                            <!-- Card that displayes help text about the question -->
                            <v-flex md3 class="mx-5">
                                <v-card elevation="5" shaped v-if="question.showInfo">
                                    <v-card-text class="text--primary font-weight-black">
                                        <p> {{question.info}} </p>
                                    </v-card-text>
                                </v-card>
                            </v-flex>

                        </v-layout>


                        <!-- Second row of content contains answer buttons -->
                        <v-flex>
                            <!-- If a button is toggled, the value of that button is saved in an array "toggle" for that page-->
                            <!-- Answer set 1, show buttons for option: Yes, no -->
                            <v-btn-toggle v-model="question.showSubQuestionList[index]" v-if="question.answerSet == 1">
                                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonSet_1"
                                    :key="button.text"> {{button.text}} </v-btn>
                            </v-btn-toggle>

                            <!-- Answer set 2, show buttons for option: No, Probably Not, Probably, Yes -->
                            <v-btn-toggle v-model="tab.answerList[index]" v-if="question.answerSet == 2">
                                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonSet_2"
                                    :key="button.text"> {{button.text}} </v-btn>
                            </v-btn-toggle>

                            <!-- Answer set 3, show buttons for option: None, Very Little, Some, A lot -->
                            <v-btn-toggle v-model="tab.answerList[index]" v-if="question.answerSet == 3">
                                <v-btn elevation="2" class="mx-2" v-for="button in answerButtonSet_3"
                                    :key="button.text"> {{button.text}} </v-btn>
                            </v-btn-toggle>
                        </v-flex>



                    </label>
                </v-card-text>

                <!-- Prev and Next button, increment or decrement current tab counter -->
                <v-row class="mx-8 my-10">
                    <v-btn class="mx-2 my-4" depressed color="primary" large @click="prevTab();">
                        <v-icon left> mdi-arrow-left </v-icon>
                        Prev
                    </v-btn>

                    <v-btn v-show="currentTab != 3" class="mx-2 my-4" depressed color="success" large @click="nextTab();">
                        Next
                        <v-icon right> mdi-arrow-right </v-icon>
                    </v-btn>

                    <!-- kanske inte behöver v-show eftersom hela kortet endast visas med v-show=currenttab -->
                    <v-btn v-show="currentTab == 3" class="mx-2 my-4" :loading="loading" depressed color="accent" large
                        @click="calcFormResult()"> Result
                        <v-icon right> mdi-form-select </v-icon>
                    </v-btn>
                </v-row>

            </div>
        </v-card>

    </div>

</template>

<script>
import axios from 'axios';

export default {

    props: {
        tabData2: Array,
        answerButtonSet_1: Array,
        answerButtonSet_2: Array,
        answerButtonSet_3: Array,
        answerSets: Array,
        questionsList: Object,
    },
    data: () => ({
        currentTab: 1,
        loading: false,
    }),

    methods: {

        hasSubQuestion(currentQuestion) {
            if (currentQuestion.hasSubQuestion == true)
                return true;
            else
                return false;
        },

        // Uses current question to find whats subquestions that belong to it, display or hides those subquestions
        showSubQuestion(currentQuestion, allQuestion, index) {

            // set Show = true to all question with sub-questiongroup
            var showSubQuestion = currentQuestion.showSubQuestionList[index];
            var subQuestionGroup = currentQuestion.subQuestionGroup;
            // console.log("answer: " + showSubQuestion);
            // console.log("showSubQuestion: " + showSubQuestion);
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
            var numberOfAnswers = tab.answerList.length;
            var numberOfAnswersWithValue = 0;
            var tabResult = 0;

            if (numberOfAnswers > 0) { // add zero as the result of tab of no buttons are pressed

                for (var i = 0; i < numberOfAnswers; i++) {
                    if (tab.questions[i].hasSubQuestion) {
                        tabResult += 0;
                    }
                    else {
                        numberOfAnswersWithValue++;
                        tabResult += tab.answerList[i] + 1;
                        console.log("tab: " + tab.id + "     Q" + (i + 1) + ": " + (tab.answerList[i] + 1));
                    }
                }
                var average = tabResult / numberOfAnswersWithValue;
                tab.result = average;
                console.log("tab: " + tab.id + "     tabResult: " + tabResult);
                console.log("tab: " + tab.id + "     average:     " + average);
                console.log("tab: " + tab.id + "     result: " + tab.result);
                console.log(" ");
            }
        },

        calcFormResult() {

            var numberOfTabs = this.tabData2.length;
            var result = [];

            for (var i = 0; i < numberOfTabs; i++) {
                this.calcTabResult(this.tabData2[i]);
                result.push(this.tabData2[i].result);

                // console.log(this.tabData.answerList);
                // console.log("length: " + this.tabData[i].answerList.length);
            }
            console.log("Form result: ", result);
            (async () => {
                var aiResult = await this.send_data_AI(result);
                console.log(aiResult.data)
                window.$cookies.config('1d');
                window.$cookies.set('isSustainable', aiResult.data);
                this.$router.push('/results')
            })()



            //return result;
        },
        prevTab() {
            if (this.currentTab != 1)
                this.currentTab -= 1;
        },

        nextTab() {
            if (this.currentTab != 5)
                this.currentTab += 1;
        },

        setCurrentTab(selectedTab) {
            this.currentTab = selectedTab;
        },

        showInfo(question) {
            if (question.showInfo == true) {
                question.showInfo = false;
            } else {
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
                    //console.log(response);
                    return response;
                })
                .catch(function (error) {
                    //console.log(error);
                    return error;
                });

            return response;

        },
    }
}
</script>