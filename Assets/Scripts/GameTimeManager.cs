using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimeManager : MonoBehaviour
{
    [SerializeField] private GameObject text;
    private TextMeshProUGUI textMeshPro;

    [SerializeField] private float limitTime = 5;//制限時間
    private float time; //残り時間

    private int nextSoundTime = 1;  //繰り返す間隔
    private float intervalTime = 0;   //経過時間
    private bool isPlaying = false;

    private AudioSource _as;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = text.GetComponent<TextMeshProUGUI>();
        _as = this.GetComponent<AudioSource>();
        time = limitTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        textMeshPro.text = time.ToString("f2");

        time -= Time.deltaTime;
        intervalTime += Time.deltaTime;

        if (time < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        if (intervalTime >= nextSoundTime)
        {
            _as.Play();
            intervalTime = 0;
        }
    }
}
