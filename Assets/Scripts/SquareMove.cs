using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public bool moving;

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position =
                transform.position + new Vector3(-0.01f, 0f, 0f);
        }
    }
}
