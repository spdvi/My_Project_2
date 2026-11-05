using System;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public GameObject door;
    private bool _doorOpening = false;
    private bool _doorClosing = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (gameObject.name == "Sensor Close")
            {
                _doorClosing = true;
            }
            else if (gameObject.name == "Sensor Open")
            {
                _doorOpening = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "Sensor Close")
        {
            _doorClosing = false;
        }
        else if (gameObject.name == "Sensor Open")
        {
            _doorOpening = false;
        }
    }

    private void Update()
    {
        if (_doorOpening && door.transform.rotation.eulerAngles.y < 90)
        {
            door.transform.Rotate(0, 0.1f, 0);
        }
        else if (_doorClosing && door.transform.rotation.eulerAngles.y > 0.5f)
        {
            door.transform.Rotate(0, -0.1f, 0);
        }
    }
    
    
}
