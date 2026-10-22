using UnityEngine;

public class AutodestroyAsteroid : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroy(gameObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10f)
        {
            Debug.Log("Asteroid Destroyed: " + gameObject.name);
            Destroy(gameObject);
        }    
    }
}
