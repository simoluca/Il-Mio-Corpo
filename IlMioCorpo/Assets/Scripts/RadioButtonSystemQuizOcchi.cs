using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections;

public class RadioButtonSystemQuizOcchi : MonoBehaviour
{
    ToggleGroup toggleGroup;
    public GameObject RetryText;
    public GameObject CorrettoPopUp;
    public AudioSource CorrectAudio;
    public AudioSource WrongAudio;
    
    private void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
       // Debug.Log(toggle.name + " _ " + toggle.GetComponentInChildren<Text>().text);
      // Debug.Log(toggle.name);

       if(toggle.name == "Falso")
       {
            CorrectAudio.Play();
             Debug.Log("ok");
            CorrettoPopUp.SetActive(true);

       }

       if(toggle.name == "Vero")
       {
            WrongAudio.Play();
            RetryText.SetActive(true);
            StartCoroutine(RemoveAfterSeconds(RetryText));
            Debug.Log("riprova");
       }
    }

     IEnumerator RemoveAfterSeconds(GameObject ob)
    {
            yield return new WaitForSeconds(1);
            RetryText.SetActive(false);
        }

}
