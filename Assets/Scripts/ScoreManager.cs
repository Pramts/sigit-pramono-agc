using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int kananScore;
    public int kiriScore;
    public int maxScore;
    public charaMain ball;

    public void AddKananScore(int increment){
        kananScore += increment;
        ball.ResetBall();
        if (kananScore >= maxScore){
            GameOver();
        }
    }

    public void AddKiriScore(int increment){
        kiriScore += increment;
        ball.ResetBall();
        if (kiriScore >= maxScore){
            GameOver();
        }      
    }    

    public void GameOver(){
        SceneManager.LoadScene("MainMenu");
    }
}
