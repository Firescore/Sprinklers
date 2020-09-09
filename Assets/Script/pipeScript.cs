using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public GameObject start, end;
    public float distance = 0;
    public float limit = 1.2f;
    public bool stop = false;
    private void Update()
    {

        distance = Vector3.Distance(start.transform.position, end.transform.position);
        if (distance >= limit + 0.3f)
        {
            stop = true;
        }
        else
        {
            stop = false;
        }

        if(distance >= limit + 0.2f)
        {
            start.GetComponent<Rigidbody>().useGravity = true;
            start.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
