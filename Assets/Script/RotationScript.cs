using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float speed;
    public float speed2;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0) 
        {
            angle += Time.deltaTime * speed;
            transform.localRotation = Quaternion.Euler(0, angle, 0);
        }
        if (speed2 > 0 )
        {
            angle += Time.deltaTime * speed2;
            transform.localRotation = Quaternion.Euler(90,0, angle);
        }
        
    }
}
