using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    int sec = 60;
    //float secF = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        /*
        secF += Time.deltaTime;
        if (secF >= 1f)
        {
            sec--;
            secF = 0f;
        }
        */

        timeText.text = sec.ToString() + " seconds";

        StartCoroutine(CountDown());

        if (sec < 0)
        {
            Application.Quit();
        }
    }

    IEnumerator CountDown()
    {
        sec--;
        yield return new WaitForSeconds(2f);
    }
}
