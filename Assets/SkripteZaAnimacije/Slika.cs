using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slika : MonoBehaviour {

    bool pomaknuto = false;
    private Renderer predmet;
    private float udaljenost = 4f;
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
        if (Manager.isActive && Input.GetMouseButtonDown(1))
        {
            if (pomaknuto)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("SlikaDesno") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    pomaknuto = false;
                    transform.GetComponent<Animation>().Play("SlikaLijevo");
                    zvuk.Play();

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("SlikaLijevo") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    pomaknuto = true;
                    transform.GetComponent<Animation>().CrossFade("SlikaDesno", 0.5f, PlayMode.StopAll);
                    zvuk.Play();


                }


            }

        }

    }
}
