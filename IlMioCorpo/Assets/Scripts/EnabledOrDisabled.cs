using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject helpPopUp;
    public GameObject speechButton;

    public void Trigger(){
        if(helpPopUp.activeInHierarchy == false){
            helpPopUp.SetActive(true);
            speechButton.SetActive(true);

        }
        else{
            helpPopUp.SetActive(false);
            speechButton.SetActive(false);
        }
    }
}