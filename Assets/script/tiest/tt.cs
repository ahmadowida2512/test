using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scaling : MonoBehaviour
{

   public float minScale = 0.05f;
    public float maxScale = 0.9f;

    float scaleFactor = 6;
    float Speed = 0.05f;


    void Start()
    {
        scaleFactor = minScale;
       
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Left
        {
            
            scaleFactor -= Speed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
          
            scaleFactor +=Speed ;
        }
        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        transform.localScale = Vector3.one * scaleFactor;
    }
}