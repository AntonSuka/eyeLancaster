using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class test : MonoBehaviour
{
    public int Testing;
    public GameObject firestyearllabtest;
    // Start is called before the first frame update
    void Start()
    {
        firestyearllabtest.GetComponent<TextMeshPro>().text = "Example" + Testing;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
