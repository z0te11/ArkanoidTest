using UnityEngine;
using TMPro;

namespace GAMEPLAY
{
    public class GameResultDisplay : MonoBehaviour
    {
        [Header("UI Elements")]
        [SerializeField] private TextMeshProUGUI _resultText;

        [Header("Messages")]
        [SerializeField] private string _winMessage = "You Win!";
        [SerializeField] private string _loseMessage = "Game Over!";

        private void OnEnable()
        {
            GameManager.OnGameWinned += ShowWinMessage;
            GameManager.OnGameLosed += ShowLoseMessage;
        }

        private void OnDisable()
        {
            GameManager.OnGameWinned -= ShowWinMessage;
            GameManager.OnGameLosed -= ShowLoseMessage;
        }

        private void ShowWinMessage()
        {
            _resultText.text = _winMessage;
        }

        private void ShowLoseMessage()
        {
            _resultText.text = _loseMessage;
        }
    }
}
