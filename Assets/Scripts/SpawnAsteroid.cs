using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Vector3 position = new Vector3(Random.Range(-4,4), 9, Random.Range(-4, 4));
            Instantiate(asteroid, position, Quaternion.identity);
        }
    }
}
