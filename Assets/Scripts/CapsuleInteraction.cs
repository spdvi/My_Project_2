using System;
using UnityEngine;

public class CapsuleInteraction : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Mouse down");
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.aquamarine;
        GetComponent<CapsuleMove>().moving = true;
    }

    
}
