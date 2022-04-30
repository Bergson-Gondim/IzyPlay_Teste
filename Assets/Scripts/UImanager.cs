using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public static UImanager _uiManager;
    public Text _pontos;
    public Text _mensagem;
    
    void Awake()
    {
        _uiManager = this;

        _pontos = transform.Find("Text_Point").GetComponent<Text>();
        _mensagem = transform.Find("Text_Mensagem").GetComponent<Text>();
        _mensagem.gameObject.SetActive(false);
    }


    //reiniciar jogo
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    //botão de ação
    public void SliceAction()
    {
        Machado2._machado2.SliceAction();
    }
}
