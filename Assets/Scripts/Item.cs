using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int _score = 1;
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.Instance.ScoreCount += _score;
        Destroy(this.gameObject);
    }
}
