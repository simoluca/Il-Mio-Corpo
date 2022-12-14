using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections;

//radiobuttonsystem for radio button type quizes, handles various popups as well as audio sources

public class RadioButtonSystems : MonoBehaviour
{
    ToggleGroup toggleGroup;
    public GameObject RetryText;
    public GameObject CorrettoPopUp;
    public AudioSource CorrectAudio;
    public AudioSource WrongAudio;
    public GameObject QuestionMarkButton;
    
    private void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
       // Debug.Log(toggle.name + " _ " + toggle.GetComponentInChildren<Text>().text);
      // Debug.Log(toggle.name);

       if(toggle.name == "Muscolo" || toggle.name == "Urina" || toggle.name == "Villi" || toggle.name == "Carpali")
       {
           // Debug.Log("ok");
            CorrectAudio.Play();
            CorrettoPopUp.SetActive(true);
            QuestionMarkButton.SetActive(false);

       }

       if(toggle.name == "Grasso" || toggle.name == "Gomma" || toggle.name == "Acqua" || toggle.name == "Bile" || toggle.name == "Tentacoli" || toggle.name == "Coni" || toggle.name == "Tarsali" || toggle.name == "Metatarsali")
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
