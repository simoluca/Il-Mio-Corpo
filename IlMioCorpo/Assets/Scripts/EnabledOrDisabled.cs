using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject helpPopUp;
    public GameObject helpPopUp2;
    public GameObject speechButton;

    public void Trigger(){
        if(helpPopUp.activeInHierarchy == false){
            helpPopUp.SetActive(true);
            helpPopUp2.SetActive(true);
            speechButton.SetActive(true);

        }
        else{
            helpPopUp.SetActive(false);
            helpPopUp2.SetActive(false);
            speechButton.SetActive(false);
        }
    }
}