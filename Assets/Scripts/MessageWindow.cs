using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageWindow : MonoBehaviour
{
    [Header("シーン上のコンポーネント")]
    [SerializeField]
    GameObject _windowPanel = null;
    [SerializeField]
    TMP_Text _nameText = null;
    [SerializeField]
    TMP_Text _letterText = null;

    [Header("デバッグ")]
    [SerializeField]
    List<string> _letters = new List<string>();
    int _letterIndex = 0;

    private void Awake()
    {
        if (!_windowPanel||!_nameText || !_letterText)
        {
            Debug.LogError($"Textコンポーネントがアタッチされていません：WindowPanel{_windowPanel}NameText{_nameText},LetterText{_letterText}");
        }
    }

    private void Update()
    {
        DebugText(Input.GetButtonDown("Fire1"), Input.GetKeyDown(KeyCode.Space));
    }

    private void DebugText(bool input)
    {
        if (input)
        {
            _letterText.text = _letters[_letterIndex % _letters.Count];
            _letterIndex++;
        }
    }
    private void DebugText(bool input,bool input2)
    {
        DebugText(input);
        DebugText(input2);
    }
}
