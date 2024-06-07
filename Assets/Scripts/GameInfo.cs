using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour
{
    public static GameInfo Instance{ get; private set; }
    private int _lane = 0;
    private int _maxLane = 2;
    private int _minLane = -2;
    
    public int Lane
    {
        get { return _lane; }
        set
        {
            if (value > _maxLane) value = _maxLane;
            else if (value < _minLane) value = _minLane;
            _lane = value;
        }
    }

    private void Awake()
    {
        Instance = this;
    }
}
