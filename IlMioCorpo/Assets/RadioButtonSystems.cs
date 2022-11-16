using UnityEngine;
using UnityEngine.UI;
using System.Linq;

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
            Debug.Log("riprova");
       }
    }

}
