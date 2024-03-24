using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private TMP_Text highScoreText;

    public void ButtonPlay()
    {
        if(PlayerPrefs.GetInt("Score") > 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            OpenPanel(2);
        }
    }
    public void OpenHighScorePanel()
    {
        highScoreText.text = PlayerPrefs.GetInt("Score").ToString();
        OpenPanel(1);
    }
    public void ButtonBack()
    {
        OpenPanel(0);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }





    private void OpenPanel(int index)
    {
        for(int i=0; i<panels.Length;i++)
        {
            if(i == index)
            {
                panels[i].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
    }
}
