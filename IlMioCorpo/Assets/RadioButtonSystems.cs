using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections;

public class RadioButtonSystems : MonoBehaviour
{
    ToggleGroup toggleGroup;
    public GameObject RetryText;

    
    private void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
       // Debug.Log(toggle.name + " _ " + toggle.GetComponentInChildren<Text>().text);
      // Debug.Log(toggle.name);

       if(toggle.name == "Muscolo")
       {
            Debug.Log("ok");
       }

       if(toggle.name == "Grasso" || toggle.name == "Gomma")
       {
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
