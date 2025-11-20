using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IScore
{
    public int Score
    {
        get;
    }
    public void GetScore(int score);
}
