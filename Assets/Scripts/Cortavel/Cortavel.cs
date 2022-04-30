using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortavel : MonoBehaviour
{
    public static Cortavel _cortavel;
    
    //Referente aos pedaços do objeto
    [Header("Pedaços")]
    [SerializeField] private bool _quebrado = false;
    [SerializeField] private GameObject _parteA;
    [SerializeField] private GameObject _parteB;
    public int _pesoPartes = 10;

    [Header("Física")]
    public Transform _forceAtPosition;
    [Space(40)]
    [SerializeField] Rigidbody _rbA;
    [SerializeField] Rigidbody _rbB;




    private void Start()
    {
        _cortavel = this;

    }

    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.gameObject.CompareTag("Lamina") && !_quebrado)
        {


            //remover o rigidbody do pai e adicionar aos filhos
            Destroy(GetComponent<Rigidbody>());

            //separar as partes do pai
            _parteA.transform.SetParent(null);
            _parteB.transform.SetParent(null);


            if (_parteA.GetComponent<Rigidbody>() == null)
            {
                _rbA = _parteA.AddComponent<Rigidbody>();
            }

            if (_parteB.GetComponent<Rigidbody>() == null)
            {
                _rbB = _parteB.AddComponent<Rigidbody>();
            }

            _rbA.mass = _pesoPartes;
            _rbB.mass = _pesoPartes;


            _rbA.AddForceAtPosition(Vector3.right * 1000, _forceAtPosition.right);
            _rbB.AddForceAtPosition(-Vector3.right * 1000, -_forceAtPosition.right);

            _quebrado = true;

            CheckPoint();
            
        }


    }

    private void CheckPoint()
    {
        GameManager._gameManager.CheckPoint(1);
    }


}
