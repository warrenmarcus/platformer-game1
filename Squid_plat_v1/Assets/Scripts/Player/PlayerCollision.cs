using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    PlayerManager playerManager;


    [SerializeField] Transform SpawnPlayer;
    public Transform[] SpawnEnemy;
    private bool isTouchingHead;
    public LayerMask headLayer;
    public Transform headCheck;
    public float headCheckRadius;

    private void OnCollisionEnter2D(Collision2D collision)
    {



 ////////////////////////////////////////////
 //// Enemy Collision
 ///////////////////////////////////////////
        isTouchingHead = Physics2D.OverlapCircle(headCheck.position, headCheckRadius, headLayer);
        if (collision.gameObject.tag == "Enemy" && isTouchingHead)
        {
            GameObject copy = collision.gameObject;
            Debug.Log("destroy");
            Destroy(collision.gameObject);


            // Enemy spawn after enemy death
            int randSpawn = Random.Range(0, SpawnEnemy.Length);
            Instantiate(copy, SpawnEnemy[randSpawn].position, transform.rotation);

        }


        if (collision.gameObject.tag == "Enemy" && !isTouchingHead)
        {
            Debug.Log("dead");
            playerManager.playerDeath.OnDeath();

        }

    }
}
