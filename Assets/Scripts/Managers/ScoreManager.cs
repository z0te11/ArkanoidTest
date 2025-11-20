using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager: MonoBehaviour
{
    private int _score = 0;
    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
        }
    }

    private void Start()
    {
        Score = 0;
    }

    public void AddScore(int points)
    {
        if (points > 0)
        {
            Score += points;
        }
    }

    public void ResetScore()
    {
        Score = 0;
    }
}
