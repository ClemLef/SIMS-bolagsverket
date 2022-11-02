<?php

use App\Http\Controllers\AiResultController;
use App\Http\Controllers\AnswerSetController;
use App\Http\Controllers\ArticleController;
use App\Http\Controllers\CategoryController;
use App\Http\Controllers\QuestionController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

//Routes to get questions to display on the front end
Route::get('questions', [QuestionController::class, 'index']);
Route::get('questions/{id}', [QuestionController::class, 'show']);

//Routes to get the previous articles to display on the front end and add the new articles to the database
Route::get('articles', [ArticleController::class, 'index']);
Route::get('articles/{id}', [ArticleController::class, 'show']);
Route::post('articles', [ArticleController::class, 'add']);

//Routes to get the previous Ai results on the front end and add the new results to the database
Route::get('ai_results', [AiResultController::class, 'index']);
Route::get('ai_results/{result_code}', [AiResultController::class, 'show']);
Route::post('ai_results', [AiResultController::class, 'add']);

//Route to get the answer sets to display on the front end
Route::get('answer_sets', [AnswerSetController::class, 'index']);

//Route to get the categories to display on the front end
Route::get('categories', [CategoryController::class, 'index']);
