using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hide : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler
{
    public List<GameObject> hide = new List<GameObject>();

    public void OnPointerEnter(PointerEventData eventData)
    {
        for (int i = 0; i < hide.Count; i++)
        {
            hide[i].SetActive(false);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        for (int i = 0; i < hide.Count; i++)
        {
            hide[i].SetActive(true);
        }
    }
}
