using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private string Menu;
    [SerializeField]
    GameObject bola,startButton,highScoreText,scoreText,quitButton,restartButton;

    [SerializeField]
    Rigidbody2D left, right;
    int score, highScore;

    [SerializeField]
    Vector3 startPos;

    public int multiplier;

    bool canPlay;

    public static GameManager instance;

    private void Awake() {
        if(instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }

        Time.timeScale = 1;
        score = 0;
        multiplier = 1;
        highScore = PlayerPrefs.HasKey("HighScore") ? PlayerPrefs.GetInt("HighScore") : 0;
        //highScoreText.GetComponent<Text>().text = "HighScore : " + highScore;
        canPlay = false;
    }

    private void Update() {
        if (!canPlay) return;
        if (Input.GetKey(KeyCode.A)) {
            left.AddTorque(40f);
        }
        else {
            left.AddTorque(-40f);
        }
        if (Input.GetKey(KeyCode.D)) {
            right.AddTorque(-40f);
        }
        else {
            right.AddTorque(40f);
        }
    }

    public void UpdateScore(int point, int mullIncrease) {
        multiplier += mullIncrease;
        score += point * multiplier;
        scoreText.GetComponent<Text>().text = "Score : " + score;
    }

    public void GameEnd() {
        Time.timeScale = 0;
        highScoreText.SetActive(true);
        quitButton.SetActive(true);
        restartButton.SetActive(true);
        if(score > highScore) {
            PlayerPrefs.SetInt("HighScore", score);
        }
        highScoreText.GetComponent<Text>().text = "HighScore : " + highScore;
    }
    public void GameStart() {
        highScoreText.SetActive(false);
        startButton.SetActive(false);
        scoreText.SetActive(true);
        Instantiate(bola, startPos, Quaternion.identity);

        canPlay = true;
    }
    public void GameQuit() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void GameRestart1() {
        SceneManager.LoadScene(1);
    }
        public void GameRestart2() {
        SceneManager.LoadScene(2);
    }
        public void GameRestart3() {
        SceneManager.LoadScene(3);
    }
    

}
