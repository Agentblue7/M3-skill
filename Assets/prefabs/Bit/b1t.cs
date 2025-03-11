using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class b1t : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public bool state = false; 

    void Update()
    {
        if (state)
        {
          
            spriteRenderer.color = Color.green;
            
        }
        else
        {
           
            spriteRenderer.color = Color.red;
           
        }
    }
    private void OnMouseUp()
    {
        state = !state; 
    }
}
