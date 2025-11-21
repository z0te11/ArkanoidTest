using UnityEngine;

namespace GAMEPLAY
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance = null;
        public static System.Action OnGameStarted;
        public static System.Action OnGameWinned;
        public static System.Action OnGameLosed;
        public static System.Action OnGameFinished;
        
        [SerializeField] private int _countEasyBlock = 6;
        [SerializeField] private int _rowEasyBlock = 4;
        [SerializeField] private int _countMidlBlock = 6;
        [SerializeField] private int _rowMidlBlock = 1;
        [SerializeField] private int _countHardBlock = 6;
        [SerializeField] private int _rowHardBlock = 1;
        [SerializeField] private SpawnSystem _spawnSystem = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public void StartGame()
        {
            Debug.Log("Start Game");
            OnGameStarted?.Invoke();
            _spawnSystem.SpawnEasyBlocks(_countEasyBlock, _rowEasyBlock);
            _spawnSystem.SpawnMidlBlocks(_countMidlBlock, _rowMidlBlock);
            _spawnSystem.SpawnHardBlocks(_countHardBlock, _rowHardBlock);
            _spawnSystem.SpawnBall();
        }

        public void WinGame()
        {
            FinishGame();
            Debug.Log("Win Game");
            OnGameWinned?.Invoke();
        }

        public void LoseGame()
        {
            FinishGame();
            Debug.Log("Lose Game");
            OnGameLosed?.Invoke();
        }

        private void FinishGame()
        {
            Debug.Log("Finish Game");
            OnGameFinished?.Invoke();
        }
    }
}