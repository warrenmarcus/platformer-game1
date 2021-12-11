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

    private void Update()
    {

////////////////////////////////////////////////////////////////
//////// Gran object function
/////////////////////////////////////////////////////////////
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Input.GetAxis("Horizontal") * transform.localScale, rayDist);

        if(grabCheck.collider !=null && grabCheck.collider.tag == "Throwable")
        {

            if (Input.GetKey(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = itemHolder;
                grabCheck.collider.gameObject.transform.position = itemHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;

            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
//////////////////////////////
//////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////



    }
}
