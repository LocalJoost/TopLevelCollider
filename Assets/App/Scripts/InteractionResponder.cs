using System;
using TMPro;
using UnityEngine;

public class InteractionResponder : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _text;

    private int _timesClicked;

    private int _timesTouched;

    private int _timesFocus;

    public void Click()
    {
        _timesClicked++;
        UpdateText();
    }
    
    public void TouchStart()
    {
        _timesTouched++;
        UpdateText();
    }

    public void OnFocus()
    {
        _timesFocus++;
        UpdateText();
    }

    private void UpdateText()
    {
        _text.text = string.Format("Clicked: {0}{1}Touched: {2}{1}Focused: {3}", 
            _timesClicked, Environment.NewLine, _timesTouched, _timesFocus);
    }
}
