using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gM;
    public List<GameObject> sprinklers = new List<GameObject>();
    void Start()
    {
        gM = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
