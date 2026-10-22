using UnityEngine;

public class PlayerThrowBomb : MonoBehaviour
{
    public float range = 3f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < asteroids.Length; i++)
            {
                if (Vector3.Distance(transform.position, asteroids[i].transform.position) < range)
                {
                    Destroy(asteroids[i]);
                }
            }
        }
    }
}
