using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public static Playerscript instance;
    public bool win;

    public ParticleSystem particals;
    public GameObject alien;

    void Start()
    {
        
    }

    void Update()
    {
        if (win) 
        {
            var test =  Instantiate(particals, transform.position,transform.rotation);
            test.transform.LookAt(new Vector3(alien.transform.position.x,alien.transform.position.y+1.5f,alien.transform.position.z));
            win = false;
            
        }
    }
    private void Awake()
    {
        instance = this;
    }
}
