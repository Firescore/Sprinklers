using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelManager : MonoBehaviour
{
    public static levelManager levelMan;
    public Slider slider;
    public TextMeshProUGUI text;
    public GameObject[] star;
    public GameObject[] level;
    public GameObject levelData;

    public GameObject Data;
    void Start()
    {
        levelMan = this;
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (levelData == null)
            {
                GameObject a = Instantiate(level[0], transform.position, Quaternion.identity);
            }

            if (levelData != null)
            {
                Next();
            }

        }
    }

    void Next()
    {
        foreach (Transform child in Data.transform)
        {
            Destroy(child.gameObject);
        }
        Instantiate(level[1], transform.position, Quaternion.identity);
    }

}
