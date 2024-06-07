using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ItemGenerate : MonoBehaviour
{
    [SerializeField] private GameObject _itemObj;
    private float _itemRangeInterval = 5f;

    private void Start()
    {
        ItemInstance();
    }

    public void ItemInstance()
    {
        for (int i = 0; i < 100; i += (int)_itemRangeInterval)
        {
            Random _random = new Random();
            int x = _random.Next(-1, 2);
            Vector3 tmp = new Vector3(x * 2, 1, this.transform.position.z+i);
            Instantiate(_itemObj, tmp, Quaternion.identity);
        }
    }
}
