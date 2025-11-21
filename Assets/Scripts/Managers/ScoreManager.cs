using UnityEngine;

namespace GAMEPLAY
{
    public class ScoreManager : MonoBehaviour
    {
        public static System.Action<int> ScoreChanged;
        private int _score = 0;
        public static ScoreManager Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
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
                ScoreChanged?.Invoke(_score);
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
}
