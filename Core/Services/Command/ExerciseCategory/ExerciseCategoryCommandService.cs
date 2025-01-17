﻿using Core.DbStorage.ExerciseCategory;
using Core.DbStorage.Exercises;

namespace Core.Services.Command.ExerciseCategory;

public class ExerciseCategoryCommandService : IExerciseCategoryCommandService
{
    private readonly IExerciseCategoryRepository _exerciseCategoryRepository;

    public ExerciseCategoryCommandService(IExerciseCategoryRepository exerciseCategoryRepository)
    {
        _exerciseCategoryRepository = exerciseCategoryRepository;
    }

    public void Add(AddExerciseCategoryRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new BadHttpRequestException("The name must contain some characters.");

        _exerciseCategoryRepository.Add(new AddExerciseCategoryCommand(request.Name));
    }
}