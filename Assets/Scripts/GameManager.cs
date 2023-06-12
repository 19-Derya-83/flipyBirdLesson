using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TMP_Text scoreText;

    public TMP_Text timeText;

    public TMP_Text totalScoreText;

    public TMP_Text totalRestTimeText;

    public float score;

    public float time;

    public GameObject gameOverPanel;

    public bool isFinish;

    public void IncreaseScore()

    {

        score++;

        scoreText.text = "Score : " + score;

    }

    private void Update()
    {

        if (isFinish) return;

        time += Time.deltaTime;

        timeText.text = time.ToString("F");

    }

    public void GameOver()

    {

        gameOverPanel.SetActive(true);

        scoreText.gameObject.SetActive(false);

        timeText.gameObject.SetActive(false);

        isFinish = true;

        totalScoreText.text = "Total Score :" + score;

        totalRestTimeText.text = "Rest Time :" + time.ToString("F");

        Time.timeScale = 0;

    }

    public void Restart()

    {

        Time.timeScale = 1;

        SceneManager.LoadScene("Game");

    }

}
