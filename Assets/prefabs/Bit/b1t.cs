using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class b1t : MonoBehaviour
{
    SpriteRenderer spriteRender;
    bool state = false;           

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
