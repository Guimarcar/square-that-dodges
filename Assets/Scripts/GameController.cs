using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public GameObject gameOver;

    public static GameController instance;

    public void Awake()
    {
        instance = this;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
