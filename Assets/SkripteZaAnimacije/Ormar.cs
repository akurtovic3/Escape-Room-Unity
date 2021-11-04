using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ormar : MonoBehaviour {

    bool otvoren = false;
    private Renderer predmet;
    private float udaljenost = 4f;
    public  AudioSource otvori;
    public AudioSource zatvori;
    private void Awake()
    {
    }
    // Use this for initialization
    void Start()
    {
        predmet = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.isActive && Input.GetMouseButtonDown(0))
        {
            if (otvoren)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("OtvoriOrmar") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    otvoren = false;
                    transform.GetComponent<Animation>().Play("ZatvoriOrmar");
                    zatvori.Play();

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("ZatvoriOrmar") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    otvoren = true;
                    transform.GetComponent<Animation>().Play("OtvoriOrmar");
                    //  transform.GetComponent<Animation>().CrossFade("OtvoriOrmar", 0.5f, PlayMode.StopAll);
                    otvori.Play();


                }


            }

        }

    }
}
