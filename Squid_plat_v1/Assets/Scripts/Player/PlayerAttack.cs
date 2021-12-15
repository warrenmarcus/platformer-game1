using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    PlayerManager playerManager;

    public Transform grabDetect;
    public Transform itemHolder;
    public float rayDist;
    public bool grabbed;
    public float throwForce;

    void Update()
    {

////////////////////////////////////////////////////////////////
//////// Grab object function
/////////////////////////////////////////////////////////////
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right *transform.localScale.x , rayDist);

        if(grabCheck.collider !=null && grabCheck.collider.tag == "Throwable")
        {

            if (Input.GetKeyDown(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = itemHolder;
                grabCheck.collider.gameObject.transform.position = itemHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbed = true;

            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }

            if (grabbed)
            {
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwForce;
            }
        }
//////////////////////////////
//////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////



    }
}
