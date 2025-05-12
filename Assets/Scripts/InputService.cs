using System;
using UnityEngine;

public class InputService : MonoBehaviour
{
    public event Action LeftButtonClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftButtonClicked?.Invoke();
        }
    }    
}
