# API developed with the Laravel framework

## Project setup
### Installation
-	Install docker compose : https://docs.docker.com/compose/install/linux/#install-using-the-repository 
-	Install php8.1 : https://computingforgeeks.com/how-to-install-php-on-debian-linux-2/
-	Install php8.1-dom
-	Make sure any user can launch docker : https://docs.docker.com/engine/install/linux-postinstall/ 
-	Install Laravel : https://laravel.com/docs/9.x/installation#getting-started-on-linux
-	Install SAIL : Sail is already installed with Laravel
### Starting the API
-	Start sail : 
o	Move to the Laravel folder
o	Execute 
```./vendor/bin/sail up```

```
npm install
```

## Documentation
The api has a number of routes implemented : 

### Questions
To get all the questions : 
```
GET /api/questions
```
To get one question with id : 
```
GET /api/questions/"id"
```

### Articles
To get all the articles : 
```
GET /api/articles
```
To get one article with id : 
```
GET /api/articles/"id"
```
To add one article in the database : 
```
POST /api/articles?title="title&url="url"&description="description"&category="category"
```

### AI Results
To get all the AI results : 
```
GET /api/ai_results
```
To get one AI results with a user result code : 
```
GET /api/ai_results/"result_code"
```
To add one AI result in the database : 
Note : all of these parameters are integers, result_code must be unique
```
POST /api/ai_results?result_code="result_code"&global="global"&social_flag="social_flag"&economical_flag="economical_flag"&environment_flag="environment_flag"&influence_flag="influence_flag"&active="active")
```

### Answer sets : 
To get all the Answer sets : 
```
GET /api/answer_sets
```

### Categories : 
To get all the categories : 
```
GET /api/categories
```
