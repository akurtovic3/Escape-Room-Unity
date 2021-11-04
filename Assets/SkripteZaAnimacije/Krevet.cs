using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krevet : MonoBehaviour {

    bool izvuceno = false;
    private Renderer predmet;
    private float udaljenost = 3f;
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
            if (izvuceno)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("KrevetNaprijed") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    izvuceno = false;
                    transform.GetComponent<Animation>().Play("KrevetNazad");
           
                    zvuk.Play();

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("KrevetNazad") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    izvuceno = true;
                    transform.GetComponent<Animation>().CrossFade("KrevetNaprijed", 0.5f, PlayMode.StopAll);
                    zvuk.Play();


                }


            }

        }

    }
}
