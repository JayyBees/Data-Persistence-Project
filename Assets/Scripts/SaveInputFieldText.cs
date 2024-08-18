using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveInputFieldText : MonoBehaviour
{
    public TMP_InputField inputField;

    public void SaveText()
    {
        // Save the input field text to PlayerPrefs
        PlayerPrefs.SetString("SavedInputFieldText", inputField.text);
        PlayerPrefs.Save();
    }
}
