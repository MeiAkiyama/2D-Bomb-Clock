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
        //���Ԏ擾
        DateTime now = DateTime.Now;
        hourNumber = now.Hour;
        minuteNumber = now.Minute;

        //�e�L�X�g�R���|�[�l���g�擾
        tex1 = text1.GetComponent<TextMeshProUGUI>();

        tex1.text = "����" + hourNumber + "�{�o�Ă��܂��B";
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
