using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineManager : MonoBehaviour
{
    public enum lineColors{
        Red,Blue,Green,Yellow
    };

    //���̔z��
    public GameObject[] lines;
    private int nowTime;
    //public int testTime;

    private void Start()
    {
        nowTime = TimeSet.getHour();
        //nowTime = testTime;

        //���Ԃɂ���������
        switch (nowTime)
        {
            case 0:
                setZero(); break;
            case 1:
            case 2:
            case 3:
            case 4:
                setOneToFour(); break;
            default:
                setTimeNumber(nowTime); break;
        }
        Debug.Log(nowTime);
    }

    private void setZero()
    {
        for(int i=0; i<lines.Length; i++)
        {
            lines[i].SetActive(true);
        }
    }

    private void setOneToFour()
    {
        for(int i = 0; i < 4; i++)
        {
            lines[i].SetActive(true);
        }
    }

    private void setTimeNumber(int time)
    {
        for(int i = 0; i < time; i++)
        {
            lines[i].SetActive(true);
        }
    }
}
