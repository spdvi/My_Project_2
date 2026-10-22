using UnityEngine;

public class PlayerInvisible : MonoBehaviour
{
    public GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (player)
            {
                if (player.activeInHierarchy == false)
                {
                    player.SetActive(true);
                }
                else
                {
                    player.SetActive(false);
                }
            }
        }    
    }
}
