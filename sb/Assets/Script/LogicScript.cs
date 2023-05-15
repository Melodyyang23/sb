using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameOverScreen;

    [ContextMenu("increase score")]
    public void addscore(int ScoreToAdd)
    {
        score = score + ScoreToAdd;
        scoretext.text = score.ToString();
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
