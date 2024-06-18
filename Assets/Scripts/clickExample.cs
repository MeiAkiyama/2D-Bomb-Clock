using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickExample : MonoBehaviour
{
    lineManager.lineColors color;
    public void OnClicked()
    {
        color = this.gameObject.GetComponent<lineColor>().getColor();
        Debug.Log(color);
    }


}
