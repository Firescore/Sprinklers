using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public static CameraTransition cT;
    public _sprinklers sp;
    public Camera cam;

    public float speedLerp = 5;
    public float speedRotation = 50;
    public bool startFounting = false;
    public Transform target;

    float distance;

    public float a;
    private void Start()
    {
        cT = this;
        a = sp.childs.Count;
    }
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);
        if(/*sp.childs.Count == GameManager.gM.sprinklers.Count*/ GameManager.gM.readyToFountain)
        {
            StartCoroutine(transition(0.3f));
        }
    }
    IEnumerator transition(float t)
    {
        yield return new WaitForSeconds(t);
        transform.position = Vector3.Lerp(transform.position, target.position, speedLerp * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, speedRotation * Time.deltaTime);
        if (distance<=0.15f)
        {
            startFounting = true;
        }
    }
}
