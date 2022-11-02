<?php

namespace App\Http\Controllers;

use App\Models\Categories;

class CategoryController extends Controller
{
    public function index()
    {
        return Categories::all();
    }
}
