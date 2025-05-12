using UnityEngine;
using TMPro;

public class CounterViewer : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _counterText.text = _counter.Count.ToString();
    }

    private void OnEnable()
    {
        _counter.CountChange += DisplayCount;
    }

    private void OnDisable()
    {
        _counter.CountChange -= DisplayCount;
    }

    private void DisplayCount()
    {
        _counterText.text = _counter.Count.ToString();
    }
}
