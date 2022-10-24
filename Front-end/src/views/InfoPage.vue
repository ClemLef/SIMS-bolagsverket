<template>

    <v-card width="90%" class="mx-auto my-10 text-left">

        <v-container class="text-center">
            <h1>
                {{infoPageHeader.header}}
            </h1>
            <h3 class="my-10">
                {{infoPageHeader.text}}
            </h3>
            <v-divider class="my-5"> </v-divider>
        </v-container>

        <v-container v-for="(info, index) in helpInfo" :key="info[index]" class="px-15 py-5">   
                <h2> {{info.headline}} </h2>
                <p> {{info.text}} </p>  
                <p class="font-weight-bold"> {{info.sorce}} </p>          
        </v-container>

        
    </v-card>
    
</template>

<script>

    export default {

        
        methods: {},
        
        data: () => ({

            infoPageHeader: {
                header: "Information page",
                text: "Welcome to the sustainability barometer! This website will let you assess the sustainability of your business idea. The service is based on artificial intelligence AI and will help you determine on which areas you can improve and tips on what to do in order to develop your business in a more sustainable way.",
            },
            
            helpInfo: [
                {
                    headline: "How it works", text: "You will fill a form with various questions about how you plan to run your business with respect to sustainability. The questions are divided into the areas social-, economical-, ecological- sustainability and positive influence. The AI- model will then process your answers and assess whether or not your intended business is sustainable based on the four dimensions. If your business turns out to be less sustainable in a particular area, the AI- model will also provide you with targeted and helpful tips on how to improve. This can for example be valuable articles or similar. ",
                },
                {
                    headline: "Why use this service?", text: "If you want to help the planet at the same time as creating groundbreaking ideas, innovations and solutions, this is the service for you. If every new entrepreneur thinks twice about how they should run their business and reduce their environmental impact, it will make a difference to the sustainability perspectives.  Even before you start your business, you get immediate feedback on how sustainable the business idea is. This can help to reach the UN:s 17 sustainability goals at an even faster pace. ",
                },
                {
                    headline: "What is sustainability and how do we measure it?", text: '“Development that meets the needs of the present without compromising the ability of future generations to meet their own needs" - Our common future 1987 The above quote is a well known definition of the concept sustainability and fits the three perspectives: social, economical and environmental sustainability. In order to classify something as sustainable, it must be sustainable in all three categories. With this in mind, the sustainability barometer was created. If the business idea fails on one perspective it can not be seen as a sustainable idea and therefore needs improvement. For this solution a fourth category was also added, positive influence, which measures how your business will help impact other businesses to work more sustainably. The AI- model is trained on historical data about ways of working to determine what sustainability is.' 
                },
                {
                    headline: "Ecological sustainability", text: "Ecological sustainability includes everything to do with the earth's ecosystem. It can be described as the importance of protecting natural ecological systems that can continue to provide people with important goods. These systems can be divided into nature's production capacity and nature's assimilation capacity. Nature's productive capacity can mean that there must be productive agricultural land, viable fish stocks, clean water and forests that can be used for fuel or other products. Nature's assimilation capacity is about nature's ability to assimilate different types of emissions and environmental impact. For example, there are processes in nature that break down chemicals into less dangerous substances. The ecological dimension is about guaranteeing that there is enough left of the natural services also in the future. (Hedenus et.al, 2014)",
                },
                {
                    headline: "Economical sustainability", text: "The economic aspect of sustainable development can be described as the ability to find effective ways to manage the economy and financial resources with consideration for today's and future generations. This includes, among other things, how we manage resources that are important for maintaining human welfare. It is about ensuring that the economic system and growth do not stand in the way of ecological and social sustainability. (Hedenus et.al, 2014)",
                },
                {
                    headline: "Social sustainability", text: "Some central parts within the social aspect are building and preserving social institutions and structures that are important to be able to meet people's needs today and in the future. Examples of what this can be about are functioning democracy, a rule of law, trust between people in a society or well-functioning international collaborations such as the UN system. Other factors that are important to work with in order to promote social sustainable development are human rights, peace, equality, health, poverty alleviation and the right to co-determination. (Hedenus et.al, 2014)",
                },
                {
                    headline: "Positive influence", text: "Positive influence is about how a business can help influence other businesses to work more sustainable. It can be for example sharing strategies and communicating tips and policies for sustainability work.",
                },
                {
                    sorce: "- Hedenus, F. Persson, M. Sprei, F (2014).HÅLLBAR UTVECKLING, Historia, definition & ingenjörens roll. http://hagesjo.se/static/books/H%C3%A5llbar_utveckling.pdf  ",
                }
            ],
        })
    }

</script>