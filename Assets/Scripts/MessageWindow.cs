using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageWindow : MonoBehaviour
{
    [Header("シーン上のコンポーネント")]
    [SerializeField]
    GameObject _windowPanel = null;
    [SerializeField]
    Text _nameText = null;
    [SerializeField]
    Text _letterText = null;

    private void Awake()
    {
        if (!_nameText || !_letterText)
        {
            Debug.LogError($"Textコンポーネントがアタッチされていません：NameText{_nameText},LetterText{_letterText}");
        }
    }
}
