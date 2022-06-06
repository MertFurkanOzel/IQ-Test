using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CircleValue : MonoBehaviour, IPointerDownHandler,IPointerEnterHandler, IPointerExitHandler
{
    public float Value;


    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(4, 4, 1);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = new Vector3(3.5f, 3.5f, 4);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (GameObject.Find("GameObject").GetComponent<Denemex>().dogrumu(Value))
        {
            
            Debug.Log("DOGRU");
            Destroy(gameObject);
           

        }

        if (GameObject.Find("Canvas").transform.childCount == 7) { GameObject.Find("GameObject").GetComponent<Denemex>().gencircle(6); }
         
            
    }
    
}




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;


//public class CircleValue : MonoBehaviour
//{
//    public float Value;

//    public void OnMouseDown()
//    {
//        Debug.Log("tıklandı");
//        if (GameObject.Find("GameObject").GetComponent<Denemex>().dogrumu(Value))
//            gameObject.SetActive(false);
//    }

//}
