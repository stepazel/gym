﻿using Core.Services.Command.Exercise;
using Core.Services.Command.ExerciseCategory;
using Core.Services.Command.Training;
using Core.Services.Query.Exercise;
using Core.Services.Query.ExerciseCategory;

namespace Core;

public class DIConfigCore
{
    public static void ConfigureServices(IServiceCollection services)
    {
        // Query services
        services.AddScoped<IExerciseQueryService, ExerciseQueryService>();
        services.AddScoped<IExerciseCategoryQueryService, ExerciseCategoryQueryService>();
        
        // Command services
        services.AddScoped<IExerciseCategoryCommandService, ExerciseCategoryCommandService>();
        services.AddScoped<IExerciseCommandService, ExerciseCommandService>();
        services.AddScoped<ITrainingCommandService, TrainingCommandService>();
    }
}