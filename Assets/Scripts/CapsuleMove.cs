using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    public bool moving = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position =
                transform.position + new Vector3(0.01f, 0f, 0f);
        }
    }
}
