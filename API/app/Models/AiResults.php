<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class AiResults extends Model
{
    use HasFactory;
    protected $fillable = ['result_code', 'global', 'social_flag', 'economical_flag', 'environment_flag', 'influence_flag', 'active'];
}
