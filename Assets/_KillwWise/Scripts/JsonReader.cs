using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public static JsonReader Instance;
    public TextAsset jsonData;
    public QuestionList questionList;

    [System.Serializable]
    public class QuestionList
    {
        public Question[] results;
    }

    [System.Serializable]
    public class Question
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public string[] incorrect_answers;
    }

    private void Awake() {
        Instance=this;
        questionList=JsonUtility.FromJson<QuestionList>(jsonData.text);
    }


    void Start()
    {
    }
}
