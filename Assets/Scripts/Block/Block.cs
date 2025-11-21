using System;
using UnityEngine;

public class Block : MonoBehaviour, IScore, ISound
{
    public event Action OnRepulsion;
    public event Action OnDestroyed;
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
        ScoreManager.Instance.AddScore(score);
    }
    
    protected void GetDamage()
    {
        _lives -= 1;
        if (_lives <= 0)
        {
            DestroyGameObject();
        }
        else
        {
            OnRepulsion?.Invoke();
        }
    }

    protected void DestroyGameObject()
    {
        GetScore(Score);
        BlockManager.Instance.RemoveBlockFromList(this.gameObject);
        OnDestroyed?.Invoke();
        Destroy(gameObject);
    }
}
