using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainSceneUI : MonoBehaviour
{
    //public TextMeshProUGUI scoreNameText;


    // Start is called before the first frame update
    void Start()
    {
        //scoreNameText.text = DataHolder.inputFieldText + " Score: 0";


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
