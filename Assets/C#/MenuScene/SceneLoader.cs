using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int scene_num;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene_num);
    }
}
