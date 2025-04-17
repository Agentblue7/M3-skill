using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitmap : MonoBehaviour
{
    [SerializeField] Byte[] bytes;
    [SerializeField] int[] values;

    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            bytes[i].SetByte(values[i]);
        }
    }
}