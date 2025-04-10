using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRender;
    public bool state = false;           

    void Start()
    {
       
        spriteRender = GetComponent<SpriteRenderer>();
    }

   

    void Update()
    {
        if (state)
        {
          
            spriteRender.color = Color.green;
            
        }
        else
        {
           
            spriteRender.color = Color.red;
           
        }
    }
    private void OnMouseUp()
    {
        state = !state; 
    }
}
