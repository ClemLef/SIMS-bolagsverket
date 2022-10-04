<template>

    <div>

        <!-- {{content}} -->
        <v-card elevation="5" width="85%" class="mx-auto my-8">  

            <!-- Create Buttons dynamically depentent on page content -->
            <v-btn @click="setCurrentTab(row.id)"
                v-for="row in content" :key="row.id"
                :class="{'mx-2' : currentTab == row.id}"
                > {{row.title}} 
            </v-btn>

            <!-- Showing correct page content -->
            <div v-for="(row, index) in content" :key="row.id[index]" v-show="currentTab == row.id">


                <h1 v-for="(question, index) in row.ecoQuestions" :key="question[index]">
                    {{question.text}}
                </h1>


            </div>
            
        </v-card>

    </div>

</template>

<script>
    export default{
        props: {
            content: Array
        },

        data: () => ({
            currentTab: 1
        }),


        methods: {   

            setCurrentTab(selectedTab){
                this.currentTab = selectedTab;
            },


        }
    }
</script>