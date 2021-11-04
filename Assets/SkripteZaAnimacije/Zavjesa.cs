using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zavjesa : MonoBehaviour {

    bool navucena = false;
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
        if (Manager.isActive && Input.GetMouseButtonDown(0))
        {
            if (navucena)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("ZavjesaDesno") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    navucena = false;
                    transform.GetComponent<Animation>().Play("ZavjesaLijevo");
                    zvuk.Play();

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("ZavjesaLijevo") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    navucena = true;
                    transform.GetComponent<Animation>().CrossFade("ZavjesaDesno", 0.5f, PlayMode.StopAll);
                    zvuk.Play();


                }


            }

        }

    }
}
