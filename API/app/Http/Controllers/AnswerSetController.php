<?php

namespace App\Http\Controllers;

use App\Models\AnswerSets;

class AnswerSetController extends Controller
{
    public function index()
    {
        return AnswerSets::all();
    }
}
