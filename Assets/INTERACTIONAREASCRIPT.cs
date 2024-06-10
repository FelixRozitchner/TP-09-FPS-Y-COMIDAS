using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INTERACTIONAREASCRIPT : MonoBehaviour
{
    public int cantPuntos;
    public Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntaje.text = "PUNTAJE: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Acá va el código que haga que detecte
        PICKUPSCRIPT pickUp;
        pickUp = other.GetComponent<PICKUPSCRIPT>();

        cantPuntos += pickUp.puntosItem;
        puntaje.text = "PUNTAJE:" + cantPuntos;
        if(pickUp.esComida == true)
        {
            Destroy(other.gameObject);
        }
    }
}
