using UnityEngine;

public class GuardMove : MonoBehaviour
{
    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint0;
    
    public float speed = 1f;
    public float rotationSpeed = 90f;

    public int goingToWaypoint = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = waypoint0.transform.position;
        goingToWaypoint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (goingToWaypoint == 1)
        {
            if (Vector3.Distance(transform.position, waypoint1.transform.position) > 0.1f)
            {
                transform.Translate(new Vector3(0, 0, speed) *  Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(0, -rotationSpeed, 0));
                goingToWaypoint = 2;
            }
        }
        else if (goingToWaypoint == 2)
        {
            if (Vector3.Distance(transform.position, waypoint2.transform.position) > 0.1f)
            {
                transform.Translate(new Vector3(0, 0, speed) *  Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(0, -rotationSpeed, 0));
                goingToWaypoint = 3;
            }
        }
        else if (goingToWaypoint == 3)
        {
            if (Vector3.Distance(transform.position, waypoint3.transform.position) > 0.1f)
            {
                transform.Translate(new Vector3(0, 0, speed) *  Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(0, -rotationSpeed, 0));
                goingToWaypoint = 0;
            }
        }
        else if (goingToWaypoint == 0)
        {
            if (Vector3.Distance(transform.position, waypoint0.transform.position) > 0.1f)
            {
                transform.Translate(new Vector3(0, 0, speed) *  Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(0, -rotationSpeed, 0));
                goingToWaypoint = 1;
            }
        }
    }
}
