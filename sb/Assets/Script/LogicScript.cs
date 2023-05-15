using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoretext;

    [ContextMenu("increase score")]
    public void addscore()
    {
        score = score + 1;
        scoretext.text = score.ToString();
    }


}
