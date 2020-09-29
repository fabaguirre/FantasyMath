using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject character;
    private Vector3 position;

    private float midpoint;
    private bool move;
    void Start()
    {
        midpoint = transform.position.x;
        move = false;
    }

    
    void FixedUpdate()
    {
        //Validamos si el personaje paso la mitad de la pantalla
        if(character.transform.position.x >= midpoint)
        {
            move = true;
            position = transform.position - character.transform.position;
            position.x = midpoint;
            //posicion = new Vector3(mitad, 0.0f, transform.position.z - character.transform.position.z);
        }
        else
        {
            move = false;
        }


        
         if (move)
         {
            transform.position = character.transform.position + position;
         }
        
    }
}
