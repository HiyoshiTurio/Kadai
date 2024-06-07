using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private GameObject _playerObj;
    private Rigidbody _rb;
    private GameObject _goal;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _playerObj = this.gameObject;
        if (_goal == null)
        {
            _goal = GameObject.FindWithTag("Goal");
        }
    }

    void Update()
    {
        Ray _ray = new Ray(transform.position, transform.TransformDirection(Vector3.down));
        RaycastHit _hit;
        if (Physics.Raycast(_ray, out _hit, 5f) && _hit.collider.gameObject.tag == "Goal")
        {
            _speed = 0;
        }

        _playerObj.transform.forward = _goal.transform.position;
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(0, 0, 1 * _speed);
    }

    public void MoveRight()
    {
        Vector3 tmp = _playerObj.transform.position;
        GameInfo.Instance.Lane += 2;
        tmp.x = GameInfo.Instance.Lane;
        _playerObj.transform.position = tmp;
    }

    public void MoveLeft()
    {
        Vector3 tmp = _playerObj.transform.position;
        GameInfo.Instance.Lane -= 2;
        tmp.x = GameInfo.Instance.Lane;
        _playerObj.transform.position = tmp;
    }
}