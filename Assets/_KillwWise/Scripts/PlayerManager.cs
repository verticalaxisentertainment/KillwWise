using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    public class Questions
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string answer;
        public List<string> incorrectAnswers;
    }

    public class QuestionList
    {
        public Questions[] questions;
    }
    public ParticleSystem DyingEffect;
    public static PlayerManager Instance;
    private void Awake() 
    {
        Instance=this;
    }
    void Start()
    {
    }

    void Update()
    {
       
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Destroy"))
        {
            GameObject.Destroy(gameObject);
            Instantiate(DyingEffect,new Vector3(transform.position.x,transform.position.y+2.5f,transform.position.z),transform.rotation);
            Debug.Log("Hit");
        }
    }
        
    }
    

