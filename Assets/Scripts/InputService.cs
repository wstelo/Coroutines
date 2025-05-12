using System;
using UnityEngine;

public class InputService : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private CounterViewer _viewer;

    public event Action CountChanged;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CountChanged?.Invoke();
        }
    }    
}
