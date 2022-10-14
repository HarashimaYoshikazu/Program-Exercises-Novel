using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageWindow : MonoBehaviour
{
    [Header("�V�[����̃R���|�[�l���g")]
    [SerializeField]
    GameObject _windowPanel = null;
    [SerializeField]
    Text _nameText = null;
    [SerializeField]
    Text _letterText = null;

    [Header("�f�o�b�O")]
    [SerializeField]
    List<string> _letters = new List<string>();
    int _letterIndex = 0;

    private void Awake()
    {
        if (!_windowPanel||!_nameText || !_letterText)
        {
            Debug.LogError($"Text�R���|�[�l���g���A�^�b�`����Ă��܂���FWindowPanel{_windowPanel}NameText{_nameText},LetterText{_letterText}");
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
