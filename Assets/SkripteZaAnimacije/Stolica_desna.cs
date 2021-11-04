using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stolica_desna : MonoBehaviour {

    bool izvuceno = false;
    private Renderer predmet;
    private float udaljenost = 5f;
    public AudioSource zvuk;
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
        if (Manager.isActive && Input.GetKeyDown("s"))
        {
            if (izvuceno)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("IzvuciStolicu") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    izvuceno = false;
                    transform.GetComponent<Animation>().Play("UvuciStolicu");
                    zvuk.Play();

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("UvuciStolicu") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    izvuceno = true;
                    transform.GetComponent<Animation>().Play("IzvuciStolicu");
                    //  transform.GetComponent<Animation>().CrossFade("OtvoriOrmar", 0.5f, PlayMode.StopAll);
                    zvuk.Play();


                }


            }

        }

    }
}
