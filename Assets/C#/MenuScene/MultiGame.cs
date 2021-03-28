using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiGame : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
