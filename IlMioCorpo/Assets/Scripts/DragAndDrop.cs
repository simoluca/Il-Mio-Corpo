using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    public Canvas myCanvas;
    private CanvasGroup canvasGroup;
    public int id;
    
    //store the starting position of each item in Vector2 variable
    public Vector2 initPos;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        initPos = transform.position;
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("BeginDrag");
       canvasGroup.blocksRaycasts = false;
    }
    
    // called on every frame moving object around
    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("OnDrag");
        // amount of movement done with mouse since last frame while holding the gameobject
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
       // Debug.Log("EndDrag");
        canvasGroup.blocksRaycasts = true;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("CLICK");
    }

    //reset position of game object to starting pisition
    public void ResetPosition()
    {
        transform.position = initPos; 
    }
    
    
}
