using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machado2 : MonoBehaviour
{
    public Rigidbody _rb;

    public Transform _atposision;
    public float _torqueForce;
    private bool _inGround;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_inGround)
            {
                _rb.AddTorque(_atposision.right * _torqueForce, ForceMode.Acceleration);
            }
            else
            {
                _rb.AddTorque(_atposision.right * _torqueForce, ForceMode.Acceleration);
                //_rb.AddForce(-transform.up* _torqueForce / 5);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        _inGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _inGround = false;
    }
}
