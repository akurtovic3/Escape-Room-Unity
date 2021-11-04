using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocetakiKraj : MonoBehaviour
{
    public Text text; 
    public GameObject glavni;
    public GameObject kraj;
    public GameObject meni;
    //    public GameObject dugme;

    public void PocniIgru()
    {
        Manager.isActive = true;
      //  text = GetComponent<Text>();
        text.text = "Resume";
        meni.SetActive(true);
        kraj.SetActive(false);
        glavni.SetActive(false);        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
