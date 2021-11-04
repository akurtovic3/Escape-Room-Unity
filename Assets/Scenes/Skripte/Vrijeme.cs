using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vrijeme : MonoBehaviour {

    float vrijeme = 0f;
    private Text text;    
    public GameObject svjetlo_oznaka;
    public GameObject meni;
    public GameObject glavni;
    public GameObject kraj;
    public AudioSource zvuk;

    public void UpdateLevelTimer(float totalseconds)
    {
        int minute = Mathf.FloorToInt(totalseconds / 60f);
        int sekunde = Mathf.RoundToInt(totalseconds % 60f);
        string formatedsekunde = sekunde.ToString();
        if (sekunde == 60)
        {
            minute += 1;
            sekunde = 0;           
        }
        if (minute == 5 && sekunde == 0)
        {
            zvuk.Play();
            text.color = new Color(255f, 0f, 0f, 1f);
            text.fontStyle = FontStyle.Bold;
            svjetlo_oznaka.SetActive(true);
        }

        Manager.trenutnoVrijeme = minute.ToString("00") + ":" + sekunde.ToString("00");
        text.text = minute.ToString("00") + ":" + sekunde.ToString("00");
        

    }

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        svjetlo_oznaka.SetActive(false);
    }


    private void Update()
    {
        if (Manager.isActive)
        {
            meni.SetActive(true);
            kraj.SetActive(false);
            glavni.SetActive(false);
            vrijeme += Time.deltaTime;
            UpdateLevelTimer(vrijeme);
        }
    }
}
