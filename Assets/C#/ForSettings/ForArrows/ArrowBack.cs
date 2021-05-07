using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowBack : MonoBehaviour
{
    public BigPlayButt _script;
    public Text _currentPit;
    private void OnMouseUp()
    {
        Debug.Log("Back");
        if (_script.CurrentScene != 1)
        {
            _script.CurrentScene--;
            _currentPit.text = "pit " + _script.CurrentScene.ToString();
        }
    }
}
