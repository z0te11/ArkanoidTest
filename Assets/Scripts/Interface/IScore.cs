using UnityEngine;

namespace GAMEPLAY
{
    public interface IScore
    {
        int Score
        {
            get;
        }
        
        void GetScore(int score);
    }
}
