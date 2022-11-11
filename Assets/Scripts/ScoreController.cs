using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreKiri;
    public Text scoreKanan;

    public ScoreManager manager;

    private void Update()
    {
        scoreKiri.text = manager.kiriScore.ToString();
        scoreKanan.text = manager.kananScore.ToString();
    }
}
