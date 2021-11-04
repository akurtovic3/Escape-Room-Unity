using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svjetlo : MonoBehaviour {
    bool upaljeno = false;
    public GameObject svjetlo;
    public GameObject svjetlo_za_svjetlo;
    public GameObject okidac;
    private float udaljenost = 4f;
    public AudioSource zvuk;

    // Use this for initialization
    void Start()
    {
        svjetlo.SetActive(false);
        svjetlo_za_svjetlo.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.isActive && Input.GetMouseButtonDown(0))
        {


            if (upaljeno)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("UpaliSvjetlo") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && okidac.GetComponent<Renderer>().isVisible)
                {
                    upaljeno = false;
                    transform.GetComponent<Animation>().Play("UgasiSvjetlo");
                    zvuk.Play();
                    svjetlo.SetActive(false);
                    svjetlo_za_svjetlo.SetActive(true);
                    
                }


            }
            else
            {

                if (!transform.GetComponent<Animation>().IsPlaying("UgasiSvjetlo") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && okidac.GetComponent<Renderer>().isVisible)
                {                    
                    upaljeno = true;
                    // transform.GetComponent<Animation>().CrossFade("UpaliSvjetlo", 0.5f, PlayMode.StopAll);
                    transform.GetComponent<Animation>().Play("UpaliSvjetlo");
                    svjetlo.SetActive(true);
                    svjetlo_za_svjetlo.SetActive(false);
                    zvuk.Play();
                }
            }

        }

    }
}
