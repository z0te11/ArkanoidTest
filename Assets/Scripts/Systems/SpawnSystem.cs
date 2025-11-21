using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private GameObject _easyBlock;
    [SerializeField] private GameObject _midlBlock;
    [SerializeField] private GameObject _hardBlock;
    [SerializeField] private GameObject _ball;

    public void SpawnEasyBlocks(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float newPos = -7.5f + 3f*i;
            GameObject newEasyBlock = Instantiate(_easyBlock, new Vector3(newPos, 1f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newEasyBlock);
        }
        for (int i = 0; i < count - 1; i++)
        {
            float newPos = -5.5f + 3f*i;
            GameObject newEasyBlock = Instantiate(_easyBlock, new Vector3(newPos, 0.3f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newEasyBlock);
        }
    }

    public void SpawnMidlBlocks(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float newPos = -7.5f + 3f*i;
            GameObject newEasyBlock = Instantiate(_midlBlock, new Vector3(newPos, 1.5f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newEasyBlock);
        }
        for (int i = 0; i < count - 1; i++)
        {
            float newPos = -5.5f + 3f*i;
            GameObject newEasyBlock = Instantiate(_midlBlock, new Vector3(newPos, 2.2f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newEasyBlock);
        }
    }

    public void SpawnHardBlocks(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float newPos = -7.5f + 3f*i;
            GameObject newHardBlock = Instantiate(_hardBlock, new Vector3(newPos, 3f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newHardBlock);
        }
        for (int i = 0; i < count - 1; i++)
        {
            float newPos = -5.5f + 3f*i;
            GameObject newHardBlock = Instantiate(_hardBlock, new Vector3(newPos, 4.2f, 0), Quaternion.identity);
            BlockManager.Instance.AddBlockInList(newHardBlock);
        }
    }

    public void SpawnBall()
    {
        GameObject newBall = Instantiate(_ball, _ball.transform.position, Quaternion.identity);
    }


}
