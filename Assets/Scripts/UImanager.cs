using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public static UImanager _uiManager;
    public Text _pontos;
    
    void Awake()
    {
        _uiManager = this;
        _pontos = transform.Find("Text_Point").GetComponent<Text>();
    }
}
