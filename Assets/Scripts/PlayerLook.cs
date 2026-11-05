using System;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private float mouseSensivity = 100f;
    private float xRotation = 0f;
    public GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        player.transform.Rotate(0, mouseX, 0);

        
        //Debug.Log(mouseY);
        //Vector3 rotation = new Vector3(mouseY, 0, 0) * Time.deltaTime * mouseSensivity;
        //Vector3.right === (1,0,0)
        // Vector3 rotation = Vector3.left * mouseY * Time.deltaTime * mouseSensivity;
        // if (transform.rotation.eulerAngles.x > -30f && transform.rotation.eulerAngles.x < 30f)
        // {
        //     transform.Rotate(rotation);
        // }

    }

    private void LateUpdate()
    {

    }
}
