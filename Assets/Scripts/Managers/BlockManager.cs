using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public static BlockManager Instance = null;
    private List<GameObject> _blocksList = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    public void AddBlockInList(GameObject go)
    {
        _blocksList.Add(go);
        Debug.Log("Blocks = " + _blocksList.Count);
    }

    public void RemoveBlockFromList(GameObject go)
    {
        _blocksList.Remove(go);
        Debug.Log("Blocks = " + _blocksList.Count);
        if (_blocksList.Count <= 0)
        {
            GameManager.Instance.WinGame();
        }
    }
}
