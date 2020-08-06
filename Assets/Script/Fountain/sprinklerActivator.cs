using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinklerActivator : MonoBehaviour
{
    public dragAndMove dam;
    public GameObject[] sprinklers;
    public Animator anime;
    public RotationScript rs;
    // Start is called before the first frame update
    void Start()
    {
        sprinklers[0].SetActive(false);
        sprinklers[1].SetActive(false);
        sprinklers[2].SetActive(false);
        anime.enabled = false;
        rs.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dam.isConneced)
        {
            sprinklers[0].SetActive(true);
            sprinklers[1].SetActive(true);
            sprinklers[2].SetActive(true);
            rs.enabled = true;
        }
    }
}
