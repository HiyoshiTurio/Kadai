using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Move _moveSc;

    private void Start()
    {
        _moveSc = this.gameObject.GetComponent<Move>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _moveSc.MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _moveSc.MoveRight();
        }
    }
}
