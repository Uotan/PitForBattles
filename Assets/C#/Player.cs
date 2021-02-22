using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator _animatorController;
    public int _speed;
    public Vector2 moveVector;
    public float JumpForce;
    public bool flip = true;

    public List<GameObject> unlockedWeapons;
    public GameObject[] allWeapons;


    //переменные для работы с состояниями и заземлением
    private bool isGrounded = false;
    CharState State;
    private void Start()
    {
        _animatorController = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)&&isGrounded)
        {
            Jump();
        }
        // if (isGrounded)
        // {
        //     _animatorController.Play("RunMan");
        // }
        CheckGround();
        walk();
        if (Input.GetKeyDown(KeyCode.B))
        {
            SwitchWeapon();
        }
    }
void Jump()
{
    rb.velocity= (Vector2.up * JumpForce);
}
     void walk()
     {
         moveVector.x = Input.GetAxis("Horizontal");
         
         rb.velocity = new Vector2(moveVector.x * _speed, rb.velocity.y);
         if (moveVector.x<0&&!flip)
         {
             Flip();
         }
         if (moveVector.x > 0 && flip)
         {
             Flip();
         }
     }

     void Flip()
     {
         flip = !flip;
         this.gameObject.transform.Rotate(0, 180, 0);
         
     }
     private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.3F);
        isGrounded = colliders.Length > 1;
        if (!isGrounded) State = CharState.Jump;
        if (isGrounded) State = CharState.Run;
        if (State==CharState.Jump)
        {
            _animatorController.Play("JumpTest");
        }
        if (State==CharState.Run)
        {
            _animatorController.Play("RunMan");
        }

    }
     public enum CharState
{
    Idle,
    Run,
    Jump
}
    private void OnTriggerEnter2D(Collider2D other) 
    {
        for (int i = 0; i < allWeapons.Length; i++)
        { 
             

            if (other.CompareTag("Weapon"))
            {
                unlockedWeapons.Add(allWeapons[i]);
                for(int k = 0; k < unlockedWeapons.Count; k++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        if (unlockedWeapons[k].name==unlockedWeapons[j].name)
                        {
                            unlockedWeapons.Remove(unlockedWeapons[k]);
                            k=0;
                            j=0;
                        }
                    }
                }  
                SwitchWeapon();
                Destroy(other.gameObject);
                        
            }   
            
                   
            
        }   
    }
    public void SwitchWeapon()
    {
        for (int i = 0; i < unlockedWeapons.Count; i++)
        {
            if (unlockedWeapons[i].activeInHierarchy)
            {
                unlockedWeapons[i].SetActive(false);
                if (i!=0)
                {
                    unlockedWeapons[i-1].SetActive(true);
                }
                else
                {
                    unlockedWeapons[unlockedWeapons.Count-1].SetActive(true);
                }
                break;
            }
        }
    }
}



