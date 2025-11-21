using UnityEngine;

namespace GAMEPLAY
{
    public class UnKillableBlock : MonoBehaviour, IScore, IInteract
    {
        [SerializeField] private int _score = 1;
        
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

        public void InteractWithObject()
        {
            GetScore(Score);
        }
    }
}
