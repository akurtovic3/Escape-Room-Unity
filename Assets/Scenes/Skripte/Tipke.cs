using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tipke : MonoBehaviour {

    public GameObject glavni;
    public GameObject kraj;
    public GameObject kljuc;
    public Text vrijeme;
    Text[] text;
    public AudioSource zvuk;
    public AudioSource klik;
    // Use this for initialization
    private void Awake()
    {
        glavni.SetActive(true);
        Manager.isActive=false;
        kraj.SetActive(false);
    }
    void Start()
    {
    }
    public void Dugme()
    {
        klik.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Manager.isActive && Input.GetKeyDown("m"))
        {
            Manager.isActive = false;
            glavni.SetActive(true);
            kraj.SetActive(false);
        }
        
        else if (Manager.isActive && Input.GetMouseButtonDown(0) && Vector3.Distance(kljuc.transform.position, GameObject.Find("ciko").transform.position) < 4f && kljuc.GetComponent<Renderer>().isVisible)
        {
            Manager.isActive = false;
            kraj.SetActive(true);
            glavni.SetActive(false);
            vrijeme.text = "";
            text = kraj.GetComponentsInChildren<Text>();
            
            Manager.pronadjen = true;
			text[2].text = Manager.trenutnoVrijeme;
			zvuk.Play();      

        }
       
    }

}
