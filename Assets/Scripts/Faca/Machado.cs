using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Machado : MonoBehaviour
{
    [Header("Atributos físicos")]
    public Rigidbody _rb;
    [Header("Forças aplicadoras")]

    public int _impulsoUp = 1;

    public int _impulsoForward = 1;


    private Vector3 _velocidade;
    private Animator _animator;



    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        //cortar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

            _animator.SetBool("Armar", true);
            _animator.SetBool("Cortar", false);

            
        }

        if (_rb.velocity.y < 0)
        {
            _animator.SetBool("Armar", false);
            _animator.SetBool("Cortar", true);
            
        }

        //_rb.velocity += _velocidade;
    }

    public void Jump()
    {
        _animator.speed = 1;

        //impulsionar
        _rb.velocity = Vector3.zero;
        _rb.AddForce(Vector3.up * _impulsoUp, ForceMode.Impulse);
        _rb.AddForce(Vector3.forward * _impulsoForward, ForceMode.Impulse);
        //_velocidade.y = Mathf.Sqrt(_impulsoUp);
        //_velocidade.z = Mathf.Sqrt(_impulsoForward);
    }



}
