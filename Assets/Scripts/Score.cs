using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     public Text scoreText;
     public int score;
 
     void Start() {
         scoreText.text = "Score: " + score; // To make sure the score text is accurate
     }
 
     public void IncreaseScore() {
         score++;
         scoreText.text = "Score: " + score;			
        } 
        
    }

