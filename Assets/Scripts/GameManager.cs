using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;


    [SerializeField] private int _points = 0;
    public bool _voceGanhou;
    public bool _vocePerdeu;


    private void Awake()
    {
        _gameManager = this;
        DontDestroyOnLoad(this);
    }

    //registrando os pontos
    public void CheckPoint(int _getPoints)
    {
        //armazenando pontos
        _points += _getPoints;
        print("ok");
        //atualizando pontos na UI
        UImanager._uiManager._pontos.text = _points.ToString();
    }

    //registrando o status de ganhar ou perder
    public void CheckStatus()
    {
        if (_voceGanhou)
        {
            UImanager._uiManager._mensagem.text = "Você Ganhou!";
            UImanager._uiManager._mensagem.gameObject.SetActive(true);
        }
        else if (_vocePerdeu)
        {
            UImanager._uiManager._mensagem.text = "Você Perdeu!";
            UImanager._uiManager._mensagem.gameObject.SetActive(true);
        }
    }
}
