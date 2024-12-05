using UnityEngine;

public class test : MonoBehaviour
{
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Mathf.Sin(Time.time);
        transform.position += new Vector3(a * Time.deltaTime * 4f, transform.position.y, transform.position.z);
    }
}
