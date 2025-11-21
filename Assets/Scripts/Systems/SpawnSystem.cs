using UnityEngine;

namespace GAMEPLAY
{
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField] private GameObject _easyBlock;
        [SerializeField] private GameObject _midlBlock;
        [SerializeField] private GameObject _hardBlock;
        [SerializeField] private GameObject _ball;

        private float _currentSpawnHeight = 0f;
        private const float ROW_HEIGHT = 0.8f;
        private const float BLOCK_SPACING = 3f;
        private const float START_X = -7.5f;

        public void SpawnEasyBlocks(int count, int row)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    float newPosX = START_X + BLOCK_SPACING * i;
                    float newPosY = _currentSpawnHeight + ROW_HEIGHT * j;
                    GameObject newEasyBlock = Instantiate(_easyBlock, new Vector3(newPosX, newPosY, 0), Quaternion.identity);
                    BlockManager.Instance.AddBlockInList(newEasyBlock);
                }
            }
            
            _currentSpawnHeight += ROW_HEIGHT * row;
        }

        public void SpawnMidlBlocks(int count, int row)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    float newPosX = START_X + BLOCK_SPACING * i;
                    float newPosY = _currentSpawnHeight + ROW_HEIGHT * j;
                    GameObject newMidlBlock = Instantiate(_midlBlock, new Vector3(newPosX, newPosY, 0), Quaternion.identity);
                    BlockManager.Instance.AddBlockInList(newMidlBlock);
                }
            }
            
            _currentSpawnHeight += ROW_HEIGHT * row;
        }

        public void SpawnHardBlocks(int count, int row)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    float newPosX = START_X + BLOCK_SPACING * i;
                    float newPosY = _currentSpawnHeight + ROW_HEIGHT * j;
                    GameObject newHardBlock = Instantiate(_hardBlock, new Vector3(newPosX, newPosY, 0), Quaternion.identity);
                    BlockManager.Instance.AddBlockInList(newHardBlock);
                }
            }
            
            _currentSpawnHeight += ROW_HEIGHT * row;
        }

        public void SpawnBall()
        {
            GameObject newBall = Instantiate(_ball, _ball.transform.position, Quaternion.identity);
        }

        public void ResetSpawnHeight()
        {
            _currentSpawnHeight = 0f;
        }
    }
}