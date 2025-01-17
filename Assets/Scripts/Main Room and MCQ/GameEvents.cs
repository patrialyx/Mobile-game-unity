﻿using UnityEngine;

/// GameEvents class is to initialise the call backs of the game

[CreateAssetMenu(fileName = "GameEvents", menuName = "Quiz/new GameEvents")]
public class GameEvents : ScriptableObject {

    public delegate void    UpdateQuestionUICallback            (Question question);
    public                  UpdateQuestionUICallback            UpdateQuestionUI                = null;

    public delegate void    UpdateQuestionAnswerCallback        (AnswerData pickedAnswer);
    public                  UpdateQuestionAnswerCallback        UpdateQuestionAnswer            = null;

    public delegate void    DisplayResolutionScreenCallback     (UIManager.ResolutionScreenType type, int score);
    public                  DisplayResolutionScreenCallback     DisplayResolutionScreen         = null;

    public delegate void    ScoreUpdatedCallback();
    public                  ScoreUpdatedCallback                ScoreUpdated                    = null;

    [HideInInspector]
    public                  int                                 level                           = 1;
    public const            int                                 maxLevel                        = 2;

    [HideInInspector]
    public                  int                                 CurrentFinalScore               = 0;
    [HideInInspector]
    public                  int                                 StartupHighscore                = 0;
}