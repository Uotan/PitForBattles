using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player1 p1;
    public Player2 p2;
    public int p1score;
    public int p2score;
    public Text scoreTXT;
    public Text statusTXT;

    public float timeMig;
    public float startTime;

    private bool Miganie = true;
    void Start()
    {
        startTime = timeMig;
        if (PlayerPrefs.HasKey("p1win"))
        {
            p1score=PlayerPrefs.GetInt("p1win");
        }
        else
        {
            PlayerPrefs.SetInt("p1win",0);
        }
        if (PlayerPrefs.HasKey("p2win"))
        {
            p2score = PlayerPrefs.GetInt("p2win");
        }
        else
        {
            PlayerPrefs.SetInt("p2win", 0);
        }
        scoreTXT.text = p1score.ToString() + ":" + p2score.ToString();
        StartCoroutine(CheckDead());

        
    }
    private void Update()
    {
        startTime -= Time.deltaTime;
        if (startTime <= 0)
        {
            Miganie = !Miganie;
            startTime = timeMig;
        }


        if (Miganie == true)
        {
            statusTXT.color = new Color(1f, 1f, 1f, 1f);
        }
        if (Miganie == false)
        {
            statusTXT.color = new Color(1f, 0.9681f, 0f, 1f);
        }




        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PlayerPrefs.DeleteKey("p1win");
            PlayerPrefs.DeleteKey("p2win");
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator CheckDead()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            
            
            if (p1.Dead==true||p2.Dead==true)
            {
                
                if (p1.Dead == true)
                {
                    statusTXT.text = "Player2 won";
                }
                if (p2.Dead == true)
                {
                    statusTXT.text = "Player1 won";
                }
                if (p1.Dead == true && p2.Dead == true)
                {
                    statusTXT.text = "draw!";
                }
                Invoke("Reload",4f);
            }
            
            
        }
        
    }
    private void Reload(){
        if (p1.Dead == true)
        {
            p2score += 1;
            PlayerPrefs.SetInt("p2win", p2score);
            scoreTXT.text = p1score.ToString() + ":" + p2score.ToString();
        }
        if (p2.Dead == true)
        {
            p1score += 1;
            PlayerPrefs.SetInt("p1win", p1score);
            scoreTXT.text = p1score.ToString() + ":" + p2score.ToString();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
    
}
