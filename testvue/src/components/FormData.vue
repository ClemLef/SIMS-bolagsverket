<template>

    <div class="my-10">

        <!-- Card that contains all questions, answers and content of each page -->
        <!-- Create Page buttons dynamically -->
        <v-btn 
            @click="setCurrentTab(row.id)"
            large elevation="3" width="17%" class="mt-10 white--text" color="green darken-4"
            :class="{'mb-1' : currentTab == row.id}"
            v-for="row in tabData" :key="row.id"
            > 
            {{row.title}} 
        </v-btn>
        
        <v-card elevation="5" width="85%" class="mx-auto">  
            
            <!-- <p> {{created()}} </p> -->

            <!-- Showing correct page content -->
            <div v-for="(tab, tabIndex) in tabData" :key="tab[tabIndex]" v-show="currentTab == tab.id">

                <!-- Row 1 contains question text, help button for extra information and help information -->
                <!-- Retrieving question object from correct page, then displaying question with corresponding answer options and help text -->
                <v-card-text v-for="(question, index) in tab.questions" :key="question[index]" class="text-left font-weight-black mx-5">

                    <!-- <label v-if="question.hasSubquestion">
                        {{debug("hello")}}
                    </label> -->
                    <!-- {{showAllSubCategory(tab, question)}} -->


                    <v-layout row class="mx-auto my-5">      

                        <!-- Question text -->
                        <v-flex md9 >
                            <p> {{question.text}} </p>
                        </v-flex>
                        
                        <!-- Help button with icon to show extra information about the question when pressed -->
                        <v-flex md1>
                            <v-btn-toggle>
                                <v-btn fab small rounded @click="showInfo(question)">
                                    <v-icon large>  mdi-progress-question </v-icon> 
                                </v-btn>
                            </v-btn-toggle> 
                        </v-flex>
                      
                        <!-- Card that displayes help text about the question -->
                        <v-flex md3 class="mx-5">
                            <v-card elevation="5" shaped v-if="question.showInfo">
                                <v-card-text class="text--primary font-weight-black">
                                    <p > {{question.info}} </p>
                                </v-card-text>
                            </v-card>
                        </v-flex>
                            
                    </v-layout>

                              
                    <!-- Second row contains answer buttons -->
                    <v-flex>
                        <!-- Answer set 1, show buttons for option: No, Probably Not, Probably, Yes -->
                        <!-- If a button is toggled, the value of that button is saved in an array "toggle" for that page-->
                        <v-btn-toggle v-model="tab.toggle[index]" v-if="question.answerSet == 1">
                            <v-btn elevation="2" class="mx-2" @click="debugFunction(tab.toggle)" v-for="button in answerTextSet_1" :key="button.text" > {{button.text}} </v-btn>
                        </v-btn-toggle>

                        <!-- Answer set 2, show buttons for option: None, Very Little, Some, A lot -->
                        <v-btn-toggle v-model="tab.toggle[index]" v-if="question.answerSet == 2">
                            <v-btn elevation="2" class="mx-2" v-for="button in answerTextSet_2" :key="button.text"> {{button.text}} </v-btn>
                        </v-btn-toggle>

                        <!-- Answer set 3, show buttons for option: Yes, no -->
                        <v-btn-toggle v-model="tab.toggle[index]" v-if="question.answerSet == 3">
                            <v-btn elevation="2" class="mx-2" v-for="button in answerTextSet_3" :key="button.text"> {{button.text}} </v-btn>
                        </v-btn-toggle>
                    </v-flex>
                    
                </v-card-text>  
                

                <!-- Prev and Next button, increment or decrement current tab counter -->
                <v-row class="mx-8 my-10">
                    <v-btn class="mx-2 my-4" depressed color="primary" large @click="prevTab">
                        <v-icon left> mdi-arrow-left </v-icon>
                        Prev
                    </v-btn>

                    <v-btn class="mx-2 my-4" depressed color="success" large @click="nextTab"> 
                        Next 
                        <v-icon right> mdi-arrow-right </v-icon>
                    </v-btn>

                    <!-- kanske inte behöver v-show eftersom hela kortet endast visas med v-show=currenttab -->
                    <v-btn v-show="currentTab == 5" class="mx-2 my-4" depressed color="accent" large @click="resultTab"> Result  
                        <v-icon right> mdi-form-select </v-icon>
                    </v-btn>

                </v-row>  
                
                
            </div> 
            <!-- <p v-for="(row, tabIndex) in tabData" :key="row[tabIndex]"> {{row.toggle}} </p> -->
        </v-card>

    </div>

</template>

<script>

    export default{

        // url: 'http://35.184.240.64/api/questions',
        // url: 'http://35.184.240.64/api/questions/1000'
        
        
        props: {
            tabData: Array,
            answerTextSet_1: Array,
            answerTextSet_2: Array,
            answerTextSet_3: Array
        },

        data: () => ({
            currentTab: 1,
            
        }),


        methods: {   

            // async created() {
            //     // GET request using fetch with async/await
            //     const response = await fetch('http://35.184.240.64/api/questions');
            //     const data = await response.json();
            //     console.log(data);
            //     // return data
            // },

            prevTab(){
                if(this.currentTab != 1)
                    this.currentTab -= 1;        
            },

            nextTab(){
                if(this.currentTab != 5)
                    this.currentTab += 1;
            },

            resultTab(){
                this.$router.push('/results')
            },

            setCurrentTab(selectedTab){
                this.currentTab = selectedTab;
            },

            showInfo(question){
                if(question.showInfo == true){
                    question.showInfo = false;
                } else{
                    question.showInfo = true;
                }
            },

            // showAllSubCategory(tab, question){
                
            //     if(question.subCategory != 0){
            //         // debug("question.subcategory: " + question.subCategory)
            //         var i = question.subCategory;
            //         this.debug(i);
            //         for(question in tab.questions){
            //             if(question.subCategory == i){
            //                 question.show == true;
            //                 // debug(question.show);
            //             }
            //         }
            //     }
            // },

            debug(debug){
                console.log(debug);
            }


        }
    }
</script>