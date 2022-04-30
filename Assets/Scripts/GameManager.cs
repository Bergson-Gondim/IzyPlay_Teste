using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;


    [SerializeField] private int _points = 0;
    

    private void Awake()
    {
        _gameManager = this;
        DontDestroyOnLoad(this);
    }

    public void CheckPoint(int _getPoints)
    {
        //armazenando pontos
        _points += _getPoints;
        print("ok");
        //atualizando pontos na UI
        UImanager._uiManager._pontos.text = _points.ToString();

    }
}
