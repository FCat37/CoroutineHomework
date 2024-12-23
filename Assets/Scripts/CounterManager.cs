using UnityEngine;

public class CounterManager : MonoBehaviour
{
    [SerializeField] private ClickHandler _clickHandler;
    [SerializeField] private Counter _counter;
    [SerializeField] private TextUpdater _textUpdater;

    private void OnEnable()
    {
        _clickHandler.OnClick += _counter.ToggleCounter;
        _counter.CounterUpdated += _textUpdater.UpdateText;
    }

    private void OnDisable()
    {
        _clickHandler.OnClick -= _counter.ToggleCounter;
        _counter.CounterUpdated -= _textUpdater.UpdateText;
    }
}
