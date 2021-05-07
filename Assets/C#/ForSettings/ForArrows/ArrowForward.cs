using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowForward : MonoBehaviour
{
    public BigPlayButt _script;
    public Text _currentPit;
    private void OnMouseUp()
    {
        Debug.Log("Forward");
        if (_script.CurrentScene!= _script.sceneNumb)
        {
            _script.CurrentScene++;
            _currentPit.text = "pit " + _script.CurrentScene.ToString();
        }
    }
}
