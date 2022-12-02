using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChangeCHIUDI : MonoBehaviour
{
    public GameObject Quiz;
    public GameObject QuizParent;
    // create method that is called when button is clicked
    public void ChangeScene()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Quiz.SetActive(false);
        QuizParent.SetActive(false);
    }   
}
