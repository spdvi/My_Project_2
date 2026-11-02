using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public float speed = 10f;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Down");
            //transform.Translate(new Vector3(1, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("D");
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("D");
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        
        if (Input.GetKeyUp(KeyCode.D))
        {
            //Debug.Log("Up");
        }    
    }
}
