using UnityEngine;

public class MoveCentro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position = new Vector3(4,0,-2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int xRandom = Random.Range(0, 9);
            transform.position = new Vector3(xRandom, 0, -2);
        }
    }
}
