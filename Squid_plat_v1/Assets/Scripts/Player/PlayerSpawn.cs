using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    PlayerManager playerManager;

    [SerializeField] Transform SpawnPlayer;
    public void Spawn()
    {
        gameObject.transform.position = SpawnPlayer.position;
        Debug.Log("Player Spawned");
    }
}
