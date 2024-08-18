using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update


    //public string playerName;

    //public void ReadStringInput(string s)
    //{
    //playerName = s;
    //Debug.Log(playerName);
    //}

    public void SaveName()
    {
        //ScoreSaver.Instance.nameOfPlayer = playerName;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        if (EditorApplication.isPlaying)
        {
            EditorApplication.ExitPlaymode();
        }
        else
        {
            Application.Quit();
        }
    }
}
