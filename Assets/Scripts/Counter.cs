using System;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _count = 0;

    public float Count => _count;
    public event Action CountChange;

    public void IncreaseValue()
    {
        _count++;
        CountChange?.Invoke();
    }
}
