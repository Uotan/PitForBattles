using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class EventNetwork : MonoBehaviour
{
    public NetworkManager manager;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (NetworkServer.active && NetworkClient.isConnected)
            {
                    manager.StopHost();
            }
            
            if (NetworkServer.active)
            {
                  manager.StopServer();
            }
            else
            {
                manager.StopClient();
            }
            Destroy(this.gameObject);
        }

    }
}
