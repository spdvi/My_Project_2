using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(horizontal);
        transform.Translate(new Vector3(horizontal,0,vertical).normalized * speed * Time.deltaTime);
    }
}
