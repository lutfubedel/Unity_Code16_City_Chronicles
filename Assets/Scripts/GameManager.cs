using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private GameObject panelWinning;

    [Header("Texts")]
    [SerializeField] private TMP_Text eventText;
    [SerializeField] private TMP_Text option_1_Text;
    [SerializeField] private TMP_Text option_2_Text;

    [Header("Circles")]
    [SerializeField] private GameObject[] circles;

    [Header("Buttons")]
    [SerializeField] private Button button_Option1;
    [SerializeField] private Button button_Option2;
    [SerializeField] private Button button_ChangeCircle;

    [Header("Values")]
    [SerializeField] private float value_money;
    [SerializeField] private float value_nature;
    [SerializeField] private float value_tech;
    [SerializeField] private float value_people;

    EventList eventList;
    int index;

    public bool gameOver;
    public bool gameWin;
    public int score;


    private void Start()
    {
        Application.targetFrameRate = 60;

        eventList = GetComponent<EventList>();

        index = 0;

        eventText.text = eventList.events[index][0];
        option_1_Text.text = eventList.events[index][1];
        option_2_Text.text = eventList.events[index][2];

    }

    private void Update()
    {
        Invoke(nameof(SetValues),2f);

        if(gameOver)
        {
            panelGameOver.SetActive(true);

            button_ChangeCircle.interactable = false;
            button_Option1.interactable = false;
            button_Option2.interactable = false;

            PlayerPrefs.SetInt("Score", score);
        }

        if(gameWin)
        {
            panelWinning.SetActive(true);

            button_ChangeCircle.interactable = false;
            button_Option1.interactable = false;
            button_Option2.interactable = false;

            PlayerPrefs.SetInt("Score", score);
        }
    }


    public void ChangeCircle()
    {
        if(circles[0].activeInHierarchy)
        {
            OpenCircle(1);
        }
        else if(circles[1].activeInHierarchy)
        {
            OpenCircle(2);
        }
        else if (circles[2].activeInHierarchy)
        {
            OpenCircle(3);
        }
        else if (circles[3].activeInHierarchy)
        {
            OpenCircle(0);
        }
    }

    private void SetText()
    {
        eventList.events.RemoveAt(index);
        index = Random.Range(0, eventList.events.Count);

        option_1_Text.text = "";
        option_2_Text.text = "";

        button_Option1.interactable = false;
        button_Option2.interactable = false;

        button_ChangeCircle.interactable = true;

        StartCoroutine(TextCreator());

    }
    private void SetValues()
    {
        value_money = circles[0].transform.GetChild(1).GetComponent<Image>().fillAmount;
        value_people = circles[1].transform.GetChild(1).GetComponent<Image>().fillAmount;
        value_tech = circles[2].transform.GetChild(1).GetComponent<Image>().fillAmount;
        value_nature = circles[3].transform.GetChild(1).GetComponent<Image>().fillAmount;

        if(value_money < 0.10f || value_nature < 0.10f || value_people < 0.10f || value_tech < 0.10f)
        {
            gameOver = true;
        }

        if(eventList.events.Count < 3)
        {
            gameWin = true;
        }
    }
    private void OpenCircle(int index)
    {
        for (int i = 0; i < circles.Length; i++)
        {
            if (i == index)
            {
                circles[i].SetActive(true);
            }
            else
            {
                circles[i].SetActive(false);
            }
        }
    }

    IEnumerator TextCreator()
    {
        eventText.text = "";
        for(int i=0; i < eventList.events[index][0].Length; i++)
        {
            eventText.text += eventList.events[index][0][i];
            yield return new WaitForSeconds(0.075f);
        }

        if (eventText.text == eventList.events[index][0])
        {
            option_1_Text.text = eventList.events[index][1];
            option_2_Text.text = eventList.events[index][2];

            button_Option1.interactable = true;
            button_Option2.interactable = true;

            score += Random.Range(10, 50);
        }
    }

    IEnumerator CircleAragment(int paramIndex, int value)
    {
        GameObject parametre1 = this.gameObject;

        switch (eventList.events[index][paramIndex])
        {
            case "Money":
                OpenCircle(0);
                parametre1 = circles[0];
                break;
            case "People":
                OpenCircle(1);
                parametre1 = circles[1];
                break;
            case "Technology":
                OpenCircle(2);
                parametre1 = circles[2];
                break;
            case "Nature":
                OpenCircle(3);
                parametre1 = circles[3];
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(0.5f);

        Image fillImage = parametre1.transform.GetChild(1).GetComponent<Image>();
        float currentFillAmount = fillImage.fillAmount;
        float targetFillAmount = currentFillAmount;

        if (eventList.events[index][value] == "+")
        {
            targetFillAmount += 0.25f;
        }
        else if(eventList.events[index][value] == "-")
        {
            targetFillAmount -= 0.25f;
        }
        else
        {
           
        }

        while (Mathf.Abs(fillImage.fillAmount - targetFillAmount) > 0.001f)
        {
            fillImage.fillAmount = Mathf.MoveTowards(fillImage.fillAmount, targetFillAmount, 0.2f * Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        yield return "Finished";
    }

    IEnumerator RunCoroutineSequentially()
    {
        yield return StartCoroutine(CircleAragment(3, 5));
        yield return StartCoroutine(CircleAragment(4, 6));
    }
    IEnumerator RunCoroutineSequentially2()
    {
        yield return StartCoroutine(CircleAragment(3, 6));
        yield return StartCoroutine(CircleAragment(4, 5));
    }

    public void StartSequentialCoroutine()
    {
        button_ChangeCircle.interactable = false;
        button_Option1.interactable = false;
        button_Option2.interactable = false;

        StartCoroutine(RunCoroutineSequentially());
        Invoke(nameof(SetText), 5f);
    }
    public void StartSequentialCoroutine2()
    {
        button_ChangeCircle.interactable = false;
        button_Option1.interactable = false;
        button_Option2.interactable = false;

        StartCoroutine(RunCoroutineSequentially2());
        Invoke(nameof(SetText), 5f);
    }

    public void PausePanelActive()
    {
        pausePanel.SetActive(!pausePanel.activeInHierarchy);
    }
    public void ButtonRestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
