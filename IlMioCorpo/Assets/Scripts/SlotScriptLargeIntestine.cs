using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// slot script for LargeIntestine

public class SlotScriptLargeIntestine : MonoBehaviour, IDropHandler
{ 
    public int id;
    public static int id_counter = 0;
    public GameObject correctpopup;


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
            if(eventData.pointerDrag.GetComponent<DragAndDrop2>().id == id)
            {
                id_counter++;
                 eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                 
                //Debug.Log("CORRECT");
                
            }
            
                else
                {
                    eventData.pointerDrag.GetComponent<DragAndDrop2>().ResetPosition();
                    //Debug.Log("FALSE");
                }
        }

        if(id_counter ==  3)
            {
                correctpopup.SetActive(true);
                //Debug.Log("Corretto");

            }
    }
     
    
}
