using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// slot script for 4 slot element quizes

public class SlotScriptSpinaDorsale : MonoBehaviour, IDropHandler
{ 
    public int id;
    public static int id_counter = 0;
    public GameObject correctpopup;
    public AudioSource CorrectAudio;
    public GameObject QuestionMarkButton;
    public bool Finished = false;


    public void OnDrop(PointerEventData eventData)
    {
        
        //Debug.Log("Item Dropped");
        
        // properly adjust the position of the item inside of the slot.
        // open the slot script and check if eventData.pointerDrag is not null.
        // pointerDrag holds the data of the game object that is currently dragged
        // and we have access to whatever component is has.
        // In this case we access the RectTransform>().anchoredPosition and make
        // it equal to the anchoredPosition of the slot.
        if(eventData.pointerDrag != null)
        {   
            // Check if item id matches slot id
            if(eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                id_counter++;
                 eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                //Debug.Log("CORRECT");
                
            }
            
                else
                {
                    eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
                    //Debug.Log("FALSE");
                }
        }

        if(id_counter ==  4)
            {

                CorrectAudio.Play();
                QuestionMarkButton.SetActive(false);
                correctpopup.SetActive(true);
                Finished = true;
                //Debug.Log("Corretto");

            }
    }
     
    
}
