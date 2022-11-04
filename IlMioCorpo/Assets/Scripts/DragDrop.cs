using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.EventSystems;



public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler

{

    [SerializeField] private Canvas canvas;
    private Vector2 mousePosition = new Vector2();





    private RectTransform rectTransform;

    private void Awake()

    {

        rectTransform = GetComponent<RectTransform>();

    }

     private void UpdateMousePosition()
    {
        mousePosition.x = Input.mousePosition.x;
        mousePosition.y = Input.mousePosition.y;
    }






    // called when begin dragging
    public void OnBeginDrag(PointerEventData eventData)

    {

        Debug.Log("OnBeginDrag");

    }



    public void OnDrag(PointerEventData eventData)

    {

        Debug.Log("OnDrag");

        // contains movement delta which is the amount that the mouse moved since the previous
        rectTransform.anchoredPosition += eventData.delta * canvas.scaleFactor;

    }


        // called when stop dragging
        public void OnEndDrag(PointerEventData eventData)

        {

            Debug.Log("OnEndDrag");

        }


        // called when mouse is pressed on top of object
        public void OnPointerDown(PointerEventData eventData)

        {

            Debug.Log("OnPointerDown");

        }



    }