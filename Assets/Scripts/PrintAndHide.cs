using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i=3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(++i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
