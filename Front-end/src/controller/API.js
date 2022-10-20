import axios from 'axios';

export default(url="http://34.135.11.174/api") =>{
    return axios.create({
        baseURL: url,
    })
}
