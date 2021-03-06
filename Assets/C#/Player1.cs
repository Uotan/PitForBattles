using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{   
    public bool Dead=false;
    public Rigidbody2D rb;
    public Animator _animatorController;
    public CapsuleCollider2D CapColl;
    public int health;
    public int _speed;
    private float slidingH;
    private float slidingV;
    public float JumpForce;
    public bool flip = true;
    

    public List<GameObject> unlockedWeapons;
    public GameObject[] allWeapons;

    public GameObject bloodEffect;
    public Transform effectPoint;



    public ForGroundChecker GroundChecker1;


    public bool isGrounded;
    private void Start()
    {
        _animatorController = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (health<=0)
           {
               Dead=true;
               CapColl.offset = new Vector2(0f, 0.19f);
                CapColl.size = new Vector2(0.39f, 0.0001f);
                rb.constraints = RigidbodyConstraints2D.FreezePositionX|RigidbodyConstraints2D.FreezeRotation;
               for (int i = 0; i < unlockedWeapons.Count; i++)
               {
                   unlockedWeapons[i].SetActive(false);
               }
              _animatorController.Play("DeadMan");
           }

        if (Dead==false)
        {
            CheckGround();
            walk();
            if (isGrounded==false)
            {
                _animatorController.Play("JumpTest");
            }
            if (rb.velocity.y==0 && rb.velocity.x==0&&isGrounded==true)
            {
                _animatorController.Play("IdlePlayer");
            }



            if(Input.GetKeyDown(KeyCode.W)&&isGrounded)
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                SwitchWeapon();
            }
        }
    }
void Jump()
{
    rb.velocity= (Vector2.up * JumpForce);
}
     void walk()
     {
         float h = 0f;
         float v = 0f;
         Vector2 smoothedInput;
            if (Input.GetKey(KeyCode.A))
            {
                 h = -1f;
                if (isGrounded==true)
                {
                    _animatorController.Play("RunMan");
                } 
            }
            else if (Input.GetKey(KeyCode.D))
            {
                h = 1f;
                if (isGrounded==true)
                {
                    _animatorController.Play("RunMan");
                }
            }
            smoothedInput = SmoothInput(h,v);

        
            float smoothedH = smoothedInput.x;
            float smoothedV = smoothedInput.y;
         
            rb.velocity = new Vector2(smoothedInput.x * _speed, rb.velocity.y);
            if (smoothedInput.x<0&&!flip)
            {
                Flip();
            }
            if (smoothedInput.x > 0 && flip)
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
        if (GroundChecker1.isGrounded==false)
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Health"))
        {
            TakeHealth();
            Destroy(other.gameObject);
        }
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

private Vector2 SmoothInput(float targetH, float targetV)
{
    float sensitivity = 10f;
    float deadZone = 0.001f;

    slidingH = Mathf.MoveTowards(slidingH,
                  targetH, sensitivity * Time.deltaTime);

    slidingV = Mathf.MoveTowards(slidingV ,
                  targetV, sensitivity * Time.deltaTime);

    return new Vector2(
           (Mathf.Abs(slidingH) < deadZone) ? 0f : slidingH ,
           (Mathf.Abs(slidingV) < deadZone) ? 0f : slidingV );
}

public void TakeDamage(int damage)
       {
           Instantiate(bloodEffect, effectPoint.position, transform.rotation);
           health -= damage;
       }
       public void TakeHealth(){
           if (Dead!=true)
           {
               if (health<50)
                {
                     health+=50;
                }
                else
                {
                    health=100;
                }
           }
       }
}



