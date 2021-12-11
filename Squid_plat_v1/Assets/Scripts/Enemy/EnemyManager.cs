using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int enemyHealth = 100;

    [SerializeField]
    internal EnemySpawn enemySpawn;

    [SerializeField]
    internal EnemyMovement enemyMovement;

    [SerializeField]
    internal EnemyDeath enemyDeath;
}
