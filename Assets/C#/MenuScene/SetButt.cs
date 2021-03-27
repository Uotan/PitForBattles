using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetButt : MonoBehaviour
{
    public Camera eyes;
    public Vector3 _eyePosition;
     private void OnMouseDown() {
        eyes.transform.position = _eyePosition;
    }

}
