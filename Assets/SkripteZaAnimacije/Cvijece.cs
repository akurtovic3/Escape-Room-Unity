using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cvijece : MonoBehaviour {

    bool izvadjeno = false;
    private Renderer predmet;
    private float udaljenost = 3f;
    private void Awake()
    {
        izvadjeno = false;
    //    cvece.transform.position = new Vector3(-4.478f, 4.573f, -5.047f);
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
            if (izvadjeno)
            {
                if (!transform.GetComponent<Animation>().IsPlaying("IzvadiCvijece") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je uvucena");
                    izvadjeno = false;
                    transform.GetComponent<Animation>().Play("UbaciCvijece");

                }
            }
            else
            {
                if (!transform.GetComponent<Animation>().IsPlaying("UbaciCvijece") && Vector3.Distance(transform.position, GameObject.Find("ciko").transform.position) < udaljenost && predmet.isVisible)
                {
                    //          print("LAdica je izvucena");
                    izvadjeno = true;
                    transform.GetComponent<Animation>().Play("IzvadiCvijece");
                    //  transform.GetComponent<Animation>().CrossFade("OtvoriOrmar", 0.5f, PlayMode.StopAll);
                    


                }


            }

        }

    }
}
