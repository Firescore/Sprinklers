using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gM;
    public List<GameObject> sprinklers = new List<GameObject>();
    public Slider sd;
    float a = 0;
    public List<GameObject> stk = new List<GameObject>();
    public List<GameObject> stkSparcles = new List<GameObject>();
    public List<Animator> ani = new List<Animator>();
    void Start()
    {
        gM = this;
        stk[0].SetActive(false);
        stk[1].SetActive(false);
        stk[2].SetActive(false);
        stkSparcles[0].SetActive(false);
        stkSparcles[1].SetActive(false);
        stkSparcles[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(a<=1)
            a += 0.01f;
        sd.value = a;
        if(sd.value >= 0.3f)
        {
            stk[0].SetActive(true);
            ani[0].SetBool("Activate", true);
            stkSparcles[0].SetActive(true);
        }
        if (sd.value >= 0.6f)
        {
            stk[1].SetActive(true);
            ani[1].SetBool("Activate", true);
            stkSparcles[1].SetActive(true);
        }
        if (sd.value >= 0.9f)
        {
            stk[2].SetActive(true);
            ani[2].SetBool("Activate", true);
            stkSparcles[2].SetActive(true);
        }
    }
}
