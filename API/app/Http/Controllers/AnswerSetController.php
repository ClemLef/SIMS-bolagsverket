<?php

namespace App\Http\Controllers;

use App\Models\AnswerSets;
use Illuminate\Http\Request;

class AnswerSetController extends Controller
{
    public function index()
    {
        return AnswerSets::all();
    }
}
