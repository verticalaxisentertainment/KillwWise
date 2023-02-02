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
    public static PlayerManager Instance;
    public QuestionList myQuestionList;
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
}
