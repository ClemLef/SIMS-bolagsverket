import API from './API.js'

export default{
    getQuestions(){
        return API().get('/questions')
    },
    getAnswerSets(){
        return API().get('/answer_sets')
    },
    getCategories(){
        return API().get('/categories')
    }
}