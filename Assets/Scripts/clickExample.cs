using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickExample : MonoBehaviour
{
    public void OnClicked()
    {
        var color = this.gameObject.GetComponent<lineColor>().getColor();
        Debug.Log(color);
    }
}
