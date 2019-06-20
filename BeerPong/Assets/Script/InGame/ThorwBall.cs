using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThorwBall : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//private void OnMouseDrag()
	//{
	//	Debug.Log("drag");
	//}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("start");
	}

	public void OnDrag(PointerEventData eventData)
	{
		Debug.Log("drag");
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log("end");
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log("enter");
	}

	public void Drag()
	{
		Debug.Log("AA");
	}
}
