using System;
using UnityEngine;

public class CylinderInteraction : MonoBehaviour
{
    //private GameObject cubeGameObject;
    private GameObject sphere;
   
    private void OnMouseDown()
    {
        // cubeGameObject = GameObject.Find("Cube");
        // cubeGameObject.GetComponent<SquareMove>().moving = true;
        sphere = GameObject.Find("Sphere");
        Vector3 spherePos = sphere.transform.position;
        sphere.transform.position = transform.position;
        transform.position = spherePos;
    }
}
