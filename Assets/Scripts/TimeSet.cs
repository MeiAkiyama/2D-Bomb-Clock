using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeSet : MonoBehaviour
{
    private static int hourNumber;
    private int minuteNumber;

    [SerializeField] GameObject text1;

    private TextMeshProUGUI tex1;

    // Start is called before the first frame update
    void Start()
    {
        //時間取得
        DateTime now = DateTime.Now;
        hourNumber = now.Hour;
        minuteNumber = now.Minute;

        //テキストコンポーネント取得
        tex1 = text1.GetComponent<TextMeshProUGUI>();

        tex1.text = "線は" + hourNumber + "本出てきます。";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int getHour()
    {
        return hourNumber;
    }

    public void startClick()
    {
        this.GetComponent<AudioSource>().Play();
        Invoke("sceneChange", 1);
    }

    public void sceneChange()
    {
        SceneManager.LoadScene("BombClockScene");
    }
}
