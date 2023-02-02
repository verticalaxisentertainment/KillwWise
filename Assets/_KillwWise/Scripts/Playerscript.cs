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
            test.transform.LookAt(alien.transform);
            win = false;
            
        }
    }
    private void Awake()
    {
        instance = this;
    }
}
