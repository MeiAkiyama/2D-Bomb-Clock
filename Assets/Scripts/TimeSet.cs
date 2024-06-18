using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeSet : MonoBehaviour
{
    private static int hourNumber;
    private int minuteNumber;

    // Start is called before the first frame update
    void Start()
    {
        //ŽžŠÔŽæ“¾
        DateTime now = DateTime.Now;
        hourNumber = now.Hour;
        minuteNumber = now.Minute;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getHour()
    {
        return hourNumber;
    }
}
