using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int _countEasyBlock = 6;
    [SerializeField] private int _countMidlBlock = 6;
    [SerializeField] private int _countHardBlock = 6;
    [SerializeField] private SpawnSystem _spawnSystem;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    public void Start()
    {
        Debug.Log("Start Game");
        _spawnSystem.SpawnEasyBlocks(_countEasyBlock);
        _spawnSystem.SpawnMidlBlocks(_countMidlBlock);
        _spawnSystem.SpawnHardBlocks(_countHardBlock);
        _spawnSystem.SpawnBall();
    }

    public void WinGame()
    {
        Debug.Log("Win Game");
        FinishGame();
    }

    public void LoseGame()
    {
        Debug.Log("Lose Game");
        FinishGame();
    }

    private void FinishGame()
    {
        Debug.Log("Finish Game");
    }
}
