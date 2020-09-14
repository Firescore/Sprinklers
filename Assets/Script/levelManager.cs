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
    public GameObject button;
    public GameObject[] star;
    public GameObject[] level;
    public GameObject levelData;

    public GameObject Data;
    void Start()
    {
        levelMan = this;
        Application.targetFrameRate = 60;
        slider.value = 0;
        for(int i = 0; i < star.Length - 1; i++)
        {
            star[i].SetActive(false);
        }
    }

}
