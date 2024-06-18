using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineJudge : MonoBehaviour
{
    public lineManager lineMg;
    lineManager.lineColors correctColor;

    // Start is called before the first frame update
    void Start()
    {
        //³‰ğ‚ÌFŠi”[
        correctColor = lineMg.getColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
