# API developed with the Laravel framework

## Project setup
### Installation
-	Install docker compose : https://docs.docker.com/compose/install/linux/#install-using-the-repository 
-	Install php8.1 : https://computingforgeeks.com/how-to-install-php-on-debian-linux-2/
-	Install php8.1-dom
-	Make sure any user can launch docker : https://docs.docker.com/engine/install/linux-postinstall/ 
-	Install Laravel : https://laravel.com/docs/9.x/installation#getting-started-on-linux
-	Install SAIL : Sail is already installed with Laravel
### Connect to the database 
- Change .env to match this : 
```
DB_CONNECTION=mysql
DB_HOST= "IP adress of the database"
DB_PORT=3306
DB_DATABASE= "name of the database"
DB_USERNAME= "username of the database user"
DB_PASSWORD= "password of the database user"
```
### Starting the API
-	Start sail : 
    -   Move to the Laravel folder
    -   To start the program, execute : 
```
./vendor/bin/sail up
```


## Documentation
This table describes the endpoints and their function. 
| Resource | Endpoint | Description |
|----------|----------|-------------|
| Questions | /questions | Contains all the questions related to sustainability to be displayed in the form on the frond end. |
| Articles | /articles | Contains all the articles related to sustainability to be display on the results page, in each section. Also used to upload the scraped articles to the database |
| AI Results | /ai_results | Contains all the results processed by the AI. Also used by the AI to upload the processed results to the database |
| Answer Sets | /answer_sets | Contains all the answer sets to be displayed in the form on the front end |
| Categories | /categories | Contains the main categories (social, environemental, economical, positive influence) to be displayed on the front end |

The api has a number of routes implemented : 
Note : Only the necessary routes were implemented.

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
