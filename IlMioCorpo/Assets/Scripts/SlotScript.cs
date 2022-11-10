using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Item Dropped");
        // properly adjust the position of the item inside of the slot.
        // open the slot script and check if eventData.pointerDrag is not null.
        // pointerDrag holds the data of the game object that is currently dragged
        // and we have access to whatever component is has.
        // In this case we access the RectTransform>().anchoredPosition and make
        // it equal to the anchoredPosition of the slot.
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
    
}