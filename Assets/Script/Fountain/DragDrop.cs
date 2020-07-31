using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DragDrop : MonoBehaviour
{
    public static DragDrop DD;

    Rigidbody rb;
    private Vector3 mOffset;
    private float mZCoord;

    public bool isMoving = false;
    private void Start()
    {
        DD = this;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

    }
    private void Update()
    {
        if (isMoving)
        {
            transform.position = GetMouseAsWorldPoint() + mOffset;
            rb.useGravity = false;
        }
    }

    void OnMouseDown()
    {
        isMoving = true;
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }
    private void OnMouseUp()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
        isMoving = false;
    }


    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen

        mousePoint.z = mZCoord;
        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}

    /*private Rigidbody rb;
    
    float startPosX;
    float startPosY;
    
    public bool mouseMoving = false;


    public float offset = 5;
    public float redius = 2;
    public GameObject rediusChecker;

    private void Start()
    {
        DD = this;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        if(rediusChecker!=null)
            rediusChecker.SetActive(false);
    }
    private void Update()
    {
        if (mouseMoving)
        {
            moveObj();
            if (rediusChecker != null)
                rediusChecker.SetActive(true);
        }
        if (rediusChecker != null)
            rediusChecker.transform.localScale = new Vector3(redius, redius, 1);
    }
    void moveObj()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.localPosition = new Vector3(mousePos.x - (startPosX * offset), mousePos.y - (startPosY * offset), this.gameObject.transform.localPosition.z);
    }
    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - this.transform.localPosition.x;
        startPosY = mousePos.y - this.transform.localPosition.y;
        mouseMoving = true;
        
    }
    private void OnMouseUp()
    {
        mouseMoving = false;
        rb.isKinematic = false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, redius);
    }*/