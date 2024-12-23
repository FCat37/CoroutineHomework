using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void UpdateText(float newValue)
    {
        if (_text != null)
        {
            _text.text = newValue.ToString();
        }
    }
}
