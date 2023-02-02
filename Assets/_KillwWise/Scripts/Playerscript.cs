using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public ParticleSystem particals;
    public GameObject alien;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempPI = (float)Math.PI * 2;
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
          var test =  Instantiate(particals, transform.position,transform.rotation);
            test.transform.LookAt(alien.transform);
            Debug.Log("Basildi");
            
        }
    }
}
