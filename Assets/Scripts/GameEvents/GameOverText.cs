using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour
{
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] TMP_Text bestScoreInfoText;
    [SerializeField] TMP_Text reasonText;
    private int previousRecord;

    public void Start()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScoreInfoText.text = "Best: " + PlayerPrefs.GetInt("BestScore").ToString();
            previousRecord = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestScoreInfoText.text = "No Highscore Yet!";
        }

        if (PlayerPrefs.GetInt("BestScore") == 0)
        {
            bestScoreInfoText.text = "No Highscore Yet!";
        }

    }

    public void UpdateGameOverText(int score)
    {
        gameOverText.text = "Game Over! \n Score: " + score;
    }

    public void UpdateBestScoreInfoText(int newScore)
    {
        
        if (newScore > previousRecord)
        {
            bestScoreInfoText.text = "New Record!";
        }
        else if (PlayerPrefs.GetInt("BestScoreDay") == 0)
        {
            bestScoreInfoText.text = "No Highscore Yet!";
        }
        else
        {
            bestScoreInfoText.text = "Best: " + PlayerPrefs.GetInt("BestScoreDay").ToString();
        }
            
    }

    public void UpdateReasonText(string reason)
    {
        reasonText.text = reason;
    }
}
