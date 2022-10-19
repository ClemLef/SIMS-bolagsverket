import API from './API.js'

export default{
    getArticles(){
        return API().get('/articles')
    },
}