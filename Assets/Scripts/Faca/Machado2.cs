using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machado2 : MonoBehaviour
{
    public static Machado2 _machado2;
    public Rigidbody _rb;

    public Transform _atposision;
    public float _torqueForce;
    private bool _inGround;
    // Start is called before the first frame update
    void Start()
    {
        _machado2 = this;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SliceAction();
        }
    }
    

    public void SliceAction()
    {

        _rb.AddTorque(_atposision.right * _torqueForce, ForceMode.Acceleration);

    }

    private void OnTriggerEnter(Collider other)
    {
        //detectar chegada
        if (other.gameObject.CompareTag("Chegada"))
        {
            //voce ganhou
            GameManager._gameManager._voceGanhou = true;
            GameManager._gameManager.CheckStatus();
        }

        //detectar perda
        if (other.gameObject.CompareTag("Perdeu"))
        {
            //voce perdeu
            GameManager._gameManager._vocePerdeu = true;
            GameManager._gameManager.CheckStatus();
        }

    }



}
