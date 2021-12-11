using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    PlayerManager playerManager;

    public void OnDeath()
    {

        Debug.Log("Player died");
        GameManager.instance.lives -= 1;
        
        Debug.Log(GameManager.instance.lives);

        // Game Over Condition
        if (GameManager.instance.lives == 0)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");

        }


        playerManager.playerSpawn.Spawn();
    }
}
