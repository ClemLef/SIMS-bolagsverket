import API from './API.js'

export default{
    getQuestion(){
        return API().get('/questions/1000')
    },
    getQuestions(){
        return API().get('/questions')
    },
    getAnswerSets(){
        return API().get('/answer_sets')
    },
    getCategorys(){
        return API().get('/categorys')
    }
}