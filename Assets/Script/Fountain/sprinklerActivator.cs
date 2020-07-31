using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinklerActivator : MonoBehaviour
{
    public GameObject[] sprinklers;
    // Start is called before the first frame update
    void Start()
    {
        sprinklers[0].SetActive(false);
        sprinklers[1].SetActive(false);
        sprinklers[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraTransition.cT.startFounting)
        {
            sprinklers[0].SetActive(true);
            sprinklers[1].SetActive(true);
            sprinklers[2].SetActive(true);
        }
    }
}
