
import axios from 'axios';

export default{
    send_data(result){
        axios.post("http://34.136.8.129:5000/post", result)
        .then(function (response) {
            // your action after success
            console.log(response);
            return response;
        })
        .catch(function (error) {
            // your action on error success
            console.log(error);
            return error;
        });
    }
}