using System;
using UnityEngine;

public class AsteoidTouchFloor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject);
        } 
        else if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        throw new NotImplementedException();
    }

    private void OnCollisionStay(Collision other)
    {
        throw new NotImplementedException();
    }
}
