<?php

use App\Http\Controllers\AiResultController;
use App\Http\Controllers\AnswerSetController;
use App\Http\Controllers\ArticleController;
use App\Http\Controllers\CategoryController;
use App\Http\Controllers\QuestionController;
use App\Models\AnswerSets;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Models\Categories;
use App\Models\Article;
use App\Models\AiResults;

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

/* Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
}); */

Route::get('questions', [QuestionController::class, 'index']);
Route::get('questions/{id}', [QuestionController::class, 'show']);

Route::get('answer_sets', [AnswerSetController::class, 'index']);

Route::get('categories', [CategoryController::class, 'index']);

Route::get('articles', [ArticleController::class, 'index']);
Route::get('articles/{id}', [ArticleController::class, 'show']);
Route::post('articles', [ArticleController::class, 'add']);

Route::get('ai_results', [AiResultController::class, 'index']);
Route::get('ai_results/{result_code}', [AiResultController::class, 'show']);
Route::post('ai_results', [AiResultController::class, 'add']);

/* Route::get('questions', function() {
    // If the Content-Type and Accept headers are set to 'application/json', 
    // this will return a JSON structure. This will be cleaned up later.
    return Questions::all();
});
 
Route::get('questions/{id}', function($id) {
    return Questions::find($id);
}); */

/* Route::get('answer_sets', function() {
    // If the Content-Type and Accept headers are set to 'application/json', 
    // this will return a JSON structure. This will be cleaned up later.
    return AnswerSets::all();
}); */


/* Route::get('categories', function() {
    // If the Content-Type and Accept headers are set to 'application/json', 
    // this will return a JSON structure. This will be cleaned up later.
    return Categories::all();
}); */

/* Route::post('articles', function(Request $request) {
    return Article::create($request->all());
}); */

/* Route::get('articles', function() {
    return Article::all();
}); */

/* Route::post('ai_results', function(Request $request) {
    return AiResults::create($request->all());
});
 */
//not the most secure but needed for the ai program to generated a unique random code
/* Route::get('ai_results', function() {
    return AiResults::all();
}); */

/* Route::get('ai_results/{result_code}', function($result_code) {
    return AiResults::where('result_code', $result_code)->first();
}); */