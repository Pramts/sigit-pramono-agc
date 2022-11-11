using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isKanan;
    public ScoreManager manager;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision == ball){
            if(isKanan){
                manager.AddKananScore(1);
            }else{
                manager.AddKiriScore(1);
            }
        }
    }
}
