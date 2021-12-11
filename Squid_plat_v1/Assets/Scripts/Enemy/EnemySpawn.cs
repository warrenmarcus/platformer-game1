using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform SpawnEnemy;
    public void Spawn()
    {
        gameObject.transform.position = SpawnEnemy.position;
        Debug.Log("Enemy Spawned");
    }
}
