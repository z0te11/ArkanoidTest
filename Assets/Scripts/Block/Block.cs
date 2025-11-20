using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour, IScore
{
    [SerializeField] private int _lives = 5;
    [SerializeField] private int _score = 10;
    public int Score
    {
        get
        {
            return _score;
        }
    }
    public void GetScore(int score)
    {
        ScoreManager.Instance.AddScore(Score);
    }
    
    protected void GetDamage()
    {
        _lives -= 1;
        if (_lives <= 0) DestroyGameObject();
    }

    protected void DestroyGameObject()
    {
        GetScore(Score);
        Destroy(gameObject);
    }
}
