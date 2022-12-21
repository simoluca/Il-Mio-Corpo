using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReadInputOssaPiedi : MonoBehaviour
{
    // this will allow to store the text entry
    private string input;
    
    public GameObject RetryText;
    public GameObject CorrettoPopUp;
    public AudioSource CorrectAudio;
    public AudioSource WrongAudio;
    public GameObject QuestionMark;

    public void ReadStringInput(string s)
    {
        input = s;
        if(s == "26")
        {
            CorrectAudio.Play();
            QuestionMark.SetActive(false);
            CorrettoPopUp.SetActive(true);
        }
            else
            {
                WrongAudio.Play();
                RetryText.SetActive(true);
                StartCoroutine(RemoveAfterSeconds(RetryText));
            }
        
        IEnumerator RemoveAfterSeconds(GameObject ob)
        {
            yield return new WaitForSeconds(1);
            RetryText.SetActive(false);
        }
       // Debug.Log(input);

    }
}
