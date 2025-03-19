using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Press A");
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Press D");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("GetKey D");
        }

    }
}
