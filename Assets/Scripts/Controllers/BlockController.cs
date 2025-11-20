using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private List<GameObject> _blocksList = new List<GameObject>();

    public void AddBlockInList(GameObject go)
    {
        _blocksList.Add(go);
    }

    public void RemoveBlockFromListg(GameObject go)
    {
        _blocksList.Remove(go);
        if (_blocksList.Count <= 0)
        {
            GameManager.Instance.WinGame();
        }
    }
}
