using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoretext;

    [ContextMenu("increase score")]
    public void addscore(int ScoreToAdd)
    {
        score = score + ScoreToAdd;
        scoretext.text = score.ToString();
    }


}
