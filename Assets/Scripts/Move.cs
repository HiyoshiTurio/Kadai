using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Rigidbody _rb;
    private GameObject _goal;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (_goal == null)
        {
            _goal = GameObject.FindWithTag("Goal");
        }

        Ray _ray = new Ray(transform.position,transform.TransformDirection(Vector3.down));
        RaycastHit _hit;
        if (Physics.Raycast(_ray, out _hit, 5f) && _hit.collider.gameObject.tag == "Goal")
        {
            _speed = 0;
        }

        this.gameObject.transform.forward = _goal.transform.position;
        _rb.velocity = new Vector3( 1 * _speed,0,0);
    }
}
