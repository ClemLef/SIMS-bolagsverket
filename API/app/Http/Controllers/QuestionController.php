<?php

namespace App\Http\Controllers;

use App\Models\Questions;

class QuestionController extends Controller
{
    public function index()
    {
        return Questions::all();
    }

    public function show($id)
    {
        return Questions::find($id);
    }
}
