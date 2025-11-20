using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("DiedZone triggered by: " + other.gameObject.name);
        
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Debug.Log("Ball entered died zone!");
            
            GameManager.Instance.LoseGame();
        }
    }
}
