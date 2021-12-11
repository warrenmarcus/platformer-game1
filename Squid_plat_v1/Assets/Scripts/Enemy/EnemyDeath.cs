using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField]
    internal EnemyManager enemyManager;

    private void OnDeath()
    {
        Debug.Log("enemy died");
        Destroy(gameObject);
        enemyManager.enemySpawn.Spawn();
    }

    
    
}
