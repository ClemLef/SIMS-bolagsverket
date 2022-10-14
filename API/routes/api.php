<?php

use App\Models\AnswerSets;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Models\Questions;

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

Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
});

Route::get('questions', function() {
    // If the Content-Type and Accept headers are set to 'application/json', 
    // this will return a JSON structure. This will be cleaned up later.
    return Questions::all();
});
 
Route::get('questions/{id}', function($id) {
    return Questions::find($id);
});

Route::get('answer_sets', function() {
    // If the Content-Type and Accept headers are set to 'application/json', 
    // this will return a JSON structure. This will be cleaned up later.
    return AnswerSets::all();
});
