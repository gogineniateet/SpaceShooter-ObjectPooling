using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

    }

    public void ScoreUpdate(int scoreValue)
    {
        score = score + scoreValue;
        //Debug.Log("Score : " + score);

    }
}
