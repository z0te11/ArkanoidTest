using UnityEngine;
using TMPro;

namespace GAMEPLAY
{
    public class ScoreDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private string _scorePrefix = "Score: ";

        private void Start()
        {
            UpdateScoreDisplay();
        }

        private void OnEnable()
        {
            ScoreManager.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            ScoreManager.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int newScore)
        {
            UpdateScoreDisplay();
        }

        private void UpdateScoreDisplay()
        {
            _scoreText.text = _scorePrefix + ScoreManager.Instance.Score.ToString();
        }
    }
}
