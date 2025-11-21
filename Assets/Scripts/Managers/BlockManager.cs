using UnityEngine;
using System.Collections.Generic;

namespace GAMEPLAY
{
    public class BlockManager : MonoBehaviour
    {
        public static BlockManager Instance = null;
        private List<GameObject> _blocksList = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public void AddBlockInList(GameObject go)
        {
            if (_blocksList == null)
            {
                _blocksList = new List<GameObject>();
            }

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
}
