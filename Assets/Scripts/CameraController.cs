using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject _player;
    private GameObject _camera;
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _camera = Camera.main.gameObject;
    }
    void Update()
    {
        _camera.transform.forward = _player.transform.forward;
        _camera.transform.position = new Vector3(_player.transform.position.x, 5, _player.transform.position.z - 15);
    }
}
