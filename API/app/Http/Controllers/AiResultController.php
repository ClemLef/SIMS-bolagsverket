<?php

namespace App\Http\Controllers;

use App\Models\AiResults;
use Illuminate\Http\Request;
use LDAP\Result;

class AiResultController extends Controller
{
    public function index()
    {
        return AiResults::all();
    }
    public function show($result_code) {
        return AiResults::where('result_code', $result_code)->first();
    }
    public function add(Request $request) {
        return AiResults::create($request->all());
    }
}
