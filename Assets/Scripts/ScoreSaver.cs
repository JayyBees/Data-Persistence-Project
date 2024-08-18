using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class ScoreSaver : MonoBehaviour
{
    public static ScoreSaver Instance;

    public TMP_InputField inputField;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public void StoreText()
    {
        //DataHolder.inputFieldText = inputField.text;

    }


    [System.Serializable]
    class SaveData
    {
        public string inputFieldText;
    }

    public void SaveText()
    {
        SaveData data = new SaveData();
        data.inputFieldText = inputField.text;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }


}
