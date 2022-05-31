using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler {

    [SerializeField] private Canvas canvas;
    //it's variable to add RectTransform component
    private RectTransform rectTransform;

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        //Raycast goes through this object and lens on the items on
        canvasGroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        //it's add transform posiiton with coursore mouse "canas.scaleFactor add acuracy
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
        //throw new System.NotImplemetedException();
    }

    public void OnPointerDown(PointerEventData eventData) => Debug.Log("OnPointerDown");// throw new System.NotImplementedException();

    public void OnDrop(PointerEventData eventData)
    {

    }
   
}
