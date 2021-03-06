using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player1 p1;
    public Player2 p2;
    void Start()
    {
        StartCoroutine(CheckDead());
    }
    IEnumerator CheckDead()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            if (p1.Dead==true||p2.Dead==true)
            {
                Invoke("Reload",4f);
            }
            
            
        }
        
    }
    private void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
    
}
