using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public static ColliderCheck CC;
    public GameObject rediusChecker1;
    public GameObject rediusChecker2;
    public float rediusSize = 1;
    Rigidbody rb;
    private void Start()
    {
        CC = this;
        rb = GetComponent<Rigidbody>();
        rediusChecker1.SetActive(false);
        rediusChecker2.SetActive(false);
    }
    bool isAdded = false;

    private void Update()
    {
        rediusChecker1.transform.localScale = new Vector3(rediusSize / 2, rediusSize, rediusSize / 2);
        rediusChecker2.transform.localScale = new Vector3(rediusSize, rediusSize, rediusSize);
        if (CameraTransition.cT.startFounting)
        {
            rediusChecker2.SetActive(false);
        }
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !isAdded)
        {
            rb.useGravity = false;
            rb.isKinematic = true;
            gameObject.GetComponent<DragDrop>().enabled = false;
            isAdded = true;
        }
    }
    private void OnMouseDown()
    {
        if(!isAdded)
            rediusChecker1.SetActive(true);
    }
    private void OnMouseUp()
    {
        rediusChecker1.SetActive(false);
        rediusChecker2.SetActive(true);
    }
}
