using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefabCircle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 pos = new Vector2(1f, 1.0f);
            GameObject a = Instantiate(prefabCircle, pos, Quaternion.identity);
            Destroy(a, 1);
        }
    }
}
