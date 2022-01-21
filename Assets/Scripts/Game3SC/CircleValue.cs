using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CircleValue : MonoBehaviour, IPointerDownHandler
{
    public float Value;
    
    
  
    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (GameObject.Find("GameObject").GetComponent<Denemex>().dogrumu(Value))
        {
            
            Debug.Log("DOGRU");
            Destroy(gameObject);
           

        }

        if (GameObject.Find("Canvas").transform.childCount == 5) { GameObject.Find("GameObject").GetComponent<Denemex>().gencircle(6); }
         
            
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
