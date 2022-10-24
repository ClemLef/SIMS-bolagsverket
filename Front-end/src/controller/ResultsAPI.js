import API from './API.js'

export default{
    getArticles(){
        return API().get('/articles')
    },
    getResult(result_code) {
        return API().get('/ai_results/' + result_code)
    }
}