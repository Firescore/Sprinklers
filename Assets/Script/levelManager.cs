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
    void Start()
    {
        levelMan = this;
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        
    }
}
