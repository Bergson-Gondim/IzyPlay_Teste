using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMachado : MonoBehaviour
{
    public Transform _target;
    [SerializeField] private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Machado").transform;
        _offset = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!GameManager._gameManager._vocePerdeu && !GameManager._gameManager._voceGanhou)
        {
            Vector3 _newPosition = _offset + _target.transform.position;
            transform.position = Vector3.Lerp(transform.position, _newPosition, .5f);
        }
    }
}
