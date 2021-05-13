using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    [SerializeField]
    private Text currentPointLayer, liveplay, bulletplay;
    public static GamePlay instance;
    public Canvas canvas;
    int point;
    int currentPoint;
    public int live;
    public int maxPoint = 0;
    public int bulleter;
    private void Start()
    {
       PlayerPrefs.SetInt("point", 0);//reset lai thi dat no thanh gia tri 0
    }
    void Awake()
    {
        live = 0;
        bulleter = 0;
        MakeInstance();
    }
    private void Update()
    {
        point = PlayerPrefs.GetInt("point");
        PlayerPrefs.SetInt("currentpoint", point);
        currentPoint = PlayerPrefs.GetInt("currentpoint");
        currentPointLayer.text = currentPoint.ToString();
        //câu điều kiện gán biến poin đủ điểm thì qua màn
        if (point == maxPoint)
        {
            try
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            catch { return; }
        }
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    [SerializeField]
    private GameObject pausePanel, gameOverPanel, gameWin;

    public void PauseGameButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReStartButton()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("GamePlay1");
    }
    public void ReStartButton2()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("GamePlay2");
    }
    public void ReStartButton4()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("GameFinal");
    }
    public void PlaneDiedShowPanel()
    {
        gameOverPanel.SetActive(true);
    }
    public void DoShowPanalWinGame()
    {
        Invoke("GameWinShowPanel", 4.0f);
    }
    public void GameWinShowPanel()
    {
        gameWin.SetActive(true);
        Time.timeScale = 0f;
    }    
    public void setlive(int point)
    {

        live = live + point;
        if (live < 5 && live >= 0)
        {
            liveplay.text = live.ToString();
        }
        else 
        {
            live--;
        }

    }
    public void setbullet(int point)
    {

        bulleter = bulleter + point;
        if (bulleter < 2 && bulleter >= 0)
        {
            bulletplay.text = bulleter.ToString();
        }
        else
        {
            bulleter--;
        }

    }

}
