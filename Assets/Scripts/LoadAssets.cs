using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, 2 * Vector3.right, Quaternion.identity);
        Instantiate(blueObj, 2 * Vector3.left, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
