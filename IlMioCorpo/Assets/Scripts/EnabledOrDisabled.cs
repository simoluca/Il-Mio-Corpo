using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject helpPopUp;

    public void Trigger(){
        if(helpPopUp.activeInHierarchy == false){
            helpPopUp.SetActive(true);

        }
        else{
            helpPopUp.SetActive(false);
        }
    }
}