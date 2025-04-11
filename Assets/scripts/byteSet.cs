using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byteSet : MonoBehaviour
{
    [SerializeField] int newValue = 0;
    [SerializeField] Byte mybyte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mybyte.SetByte(newValue);
    }
}
