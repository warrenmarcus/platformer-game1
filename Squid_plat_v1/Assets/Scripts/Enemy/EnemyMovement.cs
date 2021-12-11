using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float dirx;
    public float speed;
    private Rigidbody2D enemy;
    private Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        enemy = GetComponent<Rigidbody2D>();
        dirx = -1;
        speed = 3f;

    }



    // Update is called once per frame
    void Update()
    {
        enemy.velocity = new Vector2(dirx * speed, 0);
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag =="Object" || collision.gameObject.tag == "Throwable")
        {
        
        dirx *= -1f;
        }

    }
}
