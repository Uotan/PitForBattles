using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class LocalTestPlayer : NetworkBehaviour
{
    //������������ �������� �� PlayerPrefs
    static string net_LeftPREFS;
    KeyCode LeftBUTT;

    static string net_rightPREFS;
    KeyCode RightBUTT;

    static string net_JumpPREFS;
    KeyCode JumpBUTT;

    static string net_switchPREFS;
    KeyCode switchtBUTT;

    static string net_shootPREFS;
    KeyCode shootBUTT;

    public ReloadChecker _ReloadScript;


    public bool Dead = false;
    public Rigidbody2D rb;
    public Animator _animatorController;
    public CapsuleCollider2D CapColl;
    public int health;
    public int _speed;
    private float slidingH;
    private float slidingV;
    public float JumpForce;
    public bool flip = true;

    private SpriteRenderer _spriter;

    public List<GameObject> unlockedWeapons;
    public GameObject[] allWeapons;

    public GameObject bloodEffect;
    public Transform effectPoint;



    public ForGroundChecker GroundChecker1;
    public GameObject GroundCheckGO;

    public GameObject weapon;
    public MultiGunParapetrs weaponScript;
    public bool isGrounded;



    [Client]
    private void Start()
    {
        net_LeftPREFS = PlayerPrefs.GetString("Set_net_left");
        LeftBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), net_LeftPREFS);

        net_rightPREFS = PlayerPrefs.GetString("Set_net_right");
        RightBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), net_rightPREFS);

        net_JumpPREFS = PlayerPrefs.GetString("Set_net_jump");
        JumpBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), net_JumpPREFS);

        net_switchPREFS = PlayerPrefs.GetString("Set_net_swith");
        switchtBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), net_switchPREFS);

        net_shootPREFS = PlayerPrefs.GetString("Set_net_shoot");
        shootBUTT = (KeyCode)System.Enum.Parse(typeof(KeyCode), net_shootPREFS);



        _ReloadScript = GetComponent<ReloadChecker>();

        _spriter = GetComponent<SpriteRenderer>();


        _animatorController = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isLocalPlayer)
        {
            if (!hasAuthority)
            {
                return;
            }
            if (health <= 0)
            {
                Dead = true;
                GroundCheckGO.SetActive(false);
                CapColl.offset = new Vector2(0f, 0.19f);
                CapColl.size = new Vector2(0.39f, 0.0001f);
                rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                for (int i = 0; i < unlockedWeapons.Count; i++)
                {
                    unlockedWeapons[i].SetActive(false);
                }
                _animatorController.Play("DeadMan");
                this.gameObject.layer = 12;
                _spriter.sortingOrder = -1;
            }

            if (Dead == false)
            {
                CheckGround();
                walk();
                if (isGrounded == false)
                {
                    _animatorController.Play("JumpTest");
                }
                else if (rb.velocity.y == 0 && rb.velocity.x == 0 && isGrounded == true)
                {
                    _animatorController.Play("IdlePlayer");
                }
                else if (isGrounded == true && rb.velocity.x != 0)
                {
                    _animatorController.Play("RunMan");
                }
                else
                {
                    _animatorController.Play("IdlePlayer");
                }

                if (Input.GetKey(shootBUTT))
                {
                    for (int k = 0; k < unlockedWeapons.Count; k++)
                    {
                        if (unlockedWeapons[k].activeInHierarchy)
                        {
                            weapon = unlockedWeapons[k].gameObject;
                            weaponScript = weapon.GetComponent<MultiGunParapetrs>();
                            weaponScript.PlayerWant2shot=true;
                        }
                    }
                }
                if (Input.GetKeyUp(shootBUTT))
                {
                    for (int k = 0; k < unlockedWeapons.Count; k++)
                    {
                        if (unlockedWeapons[k].activeInHierarchy)
                        {
                            weapon = unlockedWeapons[k].gameObject;
                            weaponScript = weapon.GetComponent<MultiGunParapetrs>();
                            weaponScript.PlayerWant2shot = false;
                        }
                    }
                }

                if (Input.GetKeyDown(JumpBUTT) && isGrounded)
                {
                    Jump();
                }
                if (Input.GetKeyDown(switchtBUTT) && _ReloadScript.isReload == false)
                {
                    SwitchWeapon();
                }
            }
        }
        
    }
    void Jump()
    {
        rb.velocity = (Vector2.up * JumpForce);
    }
    void walk()
    {
        float h = 0f;
        float v = 0f;
        Vector2 smoothedInput;
        if (Input.GetKey(LeftBUTT))
        {
            h = -1f;

        }
        else if (Input.GetKey(RightBUTT))
        {
            h = 1f;

        }
        smoothedInput = SmoothInput(h, v);


        float smoothedH = smoothedInput.x;
        float smoothedV = smoothedInput.y;

        rb.velocity = new Vector2(smoothedInput.x * _speed, rb.velocity.y);
        if (smoothedInput.x < 0 && !flip)
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
        if (GroundChecker1.isGrounded == false)
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
        int addCartridges;
        if (other.CompareTag("Health"))
        {
            if (health != 100)
            {
                TakeHealth();
                Destroy(other.gameObject);
            }

        }
        if (other.CompareTag("AutoGun") || other.CompareTag("Shotgun"))
        {
            for (int i = 0; i < allWeapons.Length; i++)
            {
                if (other.tag == allWeapons[i].name)
                {
                    unlockedWeapons.Add(allWeapons[i]);
                    allWeapons[i].SetActive(true);
                    for (int k = 0; k < unlockedWeapons.Count; k++)
                    {
                        if (unlockedWeapons[k].activeInHierarchy && unlockedWeapons[k].name != other.tag)
                        {
                            unlockedWeapons[k].SetActive(false);
                            break;
                        }
                    }
                }
            }
            for (int k = 0; k < unlockedWeapons.Count; k++)
            {
                for (int j = k + 1; j < unlockedWeapons.Count; j++)
                {
                    if (unlockedWeapons[k].name == unlockedWeapons[j].name)
                    {
                        weapon = unlockedWeapons[k].gameObject;
                        weaponScript = weapon.GetComponent<MultiGunParapetrs>();
                        addCartridges = weaponScript.startCartridges;
                        weaponScript.cartridges += addCartridges;
                        unlockedWeapons.Remove(unlockedWeapons[j]);
                    }
                }
            }
            Destroy(other.gameObject);
        }
    }
    public void SwitchWeapon()
    {
        for (int i = 0; i < unlockedWeapons.Count; i++)
        {
            if (unlockedWeapons[i].activeInHierarchy)
            {
                unlockedWeapons[i].SetActive(false);

                if (i != 0)
                {
                    unlockedWeapons[i - 1].SetActive(true);
                    break;
                }
                else
                {
                    unlockedWeapons[unlockedWeapons.Count - 1].SetActive(true);
                    break;
                }

            }
        }
    }


    private Vector2 SmoothInput(float targetH, float targetV)
    {
        float sensitivity = 10f;
        float deadZone = 0.001f;

        slidingH = Mathf.MoveTowards(slidingH,
                      targetH, sensitivity * Time.deltaTime);

        slidingV = Mathf.MoveTowards(slidingV,
                      targetV, sensitivity * Time.deltaTime);

        return new Vector2(
               (Mathf.Abs(slidingH) < deadZone) ? 0f : slidingH,
               (Mathf.Abs(slidingV) < deadZone) ? 0f : slidingV);
    }

    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, effectPoint.position, transform.rotation);
        health -= damage;
    }
    public void TakeHealth()
    {
        if (Dead != true)
        {
            if (health < 75)
            {
                health += 25;
            }
            else
            {
                health = 100;
            }
        }
    }
}
