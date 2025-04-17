using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyPixel : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject Pixel;
    [SerializeField] private Byte byteR;
    [SerializeField] private Byte byteG;
    [SerializeField] private Byte byteB;
    [SerializeField] private string colorCode;

    private void Start()
    {

    }

    private void Update()
    {
        if (Pixel != null)
        {
            spriteRenderer = Pixel.GetComponent<SpriteRenderer>();
        }

        if (byteR != null && byteG != null && byteB != null && Pixel != null)
        {
            colorCode = "#" + byteR.getHex() + byteG.getHex() + byteB.getHex();

            if (UnityEngine.ColorUtility.TryParseHtmlString(colorCode, out Color newColor))
            {
                spriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogError("invalid hex color: " + colorCode);
            }
        }
    }
}