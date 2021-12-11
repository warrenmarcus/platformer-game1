using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    internal PlayerMovement playerMovement;

    [SerializeField]
    internal PlayerDeath playerDeath;

    [SerializeField]
    internal PlayerCollision enemyCollision;

    [SerializeField]
    internal PlayerSpawn playerSpawn;

}
