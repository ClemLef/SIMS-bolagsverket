import axios from 'axios';

export default(url="https://34.135.11.174/api") =>{
    return axios.create({
        baseURL: url,
    })
}
