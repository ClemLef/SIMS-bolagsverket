import API from './API.js'

export default{
    getQuestion(){
        return API().get('/questions/1000')
    }
}