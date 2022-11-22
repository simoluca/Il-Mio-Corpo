using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // array for levels
    public GameObject[] Levels;

    //store current level number
    int currentLevel;

    public void correctAnswer()
    {
        Debug.Log("CORRECT ");
        /*
        //checks if this isn't the last level
        if(currentLevel + 1 != Levels.Length)
        {
            //disactivate the current level 
            Levels[currentLevel].SetActive(false);

            //update current level
            currentLevel++;

            //activate next level
            Levels[currentLevel].SetActive(true);
        }
        */
    }
    



}
