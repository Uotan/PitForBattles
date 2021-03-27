using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForGroundChecker : MonoBehaviour
{
    public bool isGrounded;
    private void OnTriggerEnter2D(Collider2D other) {
        //if (other.gameObject.tag!="Enemy"||other.gameObject.tag!="Enemy1")
        //{
        //    //Debug.Log(other.gameObject.name);
        //    isGrounded = true;
        //}
        if (other.gameObject.layer == 8 || other.gameObject.layer == 9)
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        //if (other.gameObject.tag!="Enemy"||other.gameObject.tag!="Enemy1")
        //{
        //    //Debug.Log(other.gameObject.name);
        //    isGrounded = false;
        //}
        if (other.gameObject.layer==8||other.gameObject.layer==9)
        {
            isGrounded = false;
        }
    }
}
