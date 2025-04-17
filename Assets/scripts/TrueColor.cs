using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class TrueColor : MonoBehaviour
{
    int index;
    [SerializeField] TCPixel Pixel;
    TCPixel[] pixels = new TCPixel[153];


    private void Start()
    {
        Quaternion rotatie = Quaternion.identity;

        for (int i = 0; i < pixels.Length; i++)
        {
            int que = i / 9;
            int column = i % 9;
            Vector3 spawnPositie = new Vector3(que - 8, column - 4, 0);

            pixels[i] = Instantiate(Pixel, spawnPositie, rotatie);
        }
    }
    private void Update()
    {
        pixels[index].RandomColor();

        index++;
        if (index == pixels.Length)
        {
            index = 0;
        }
    }

}