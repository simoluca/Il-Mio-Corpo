using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//https://www.youtube.com/watch?v=pEOetyJ0ULE   3.12
public class DragAndDrop2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    public Canvas myCanvas;
    private CanvasGroup canvasGroup;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
       canvasGroup.blocksRaycasts = false;
    }
    
    // called on every frame moving object around
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        // amount of movement done with mouse since last frame while holding the gameobject
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("CLICK");
    }
    
    
}
