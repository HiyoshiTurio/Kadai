using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    public static ScoreManager Instance { get; private set; }
    private int _scoreCount = 0;

    public int ScoreCount
    {
        get
        {
            return _scoreCount;
        }
        set
        {
            _scoreCount = value;
            _scoreText.text = _scoreCount.ToString();
        }
    }

    private void Awake()
    {
        Instance = this;
    }
}
