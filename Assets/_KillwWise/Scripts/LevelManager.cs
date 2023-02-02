using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.ComponentModel;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public TMP_Text questionText;
    public Button[] answerButtons;

    int b=0;
    int correctAnswerIndex;
    public int selectedQuestion;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

        selectedQuestion=Random.Range(0,JsonReader.Instance.questionList.results.Length-1);
        questionText.text=JsonReader.Instance.questionList.results[selectedQuestion].question;

        correctAnswerIndex=Random.Range(0,3);

        
        answerButtons[correctAnswerIndex].GetComponentInChildren<TMP_Text>().text=JsonReader.Instance.questionList.results[selectedQuestion].correct_answer;
            
        for(int i=0;i<4;i++)
        {
            if(correctAnswerIndex!=i)
            {
                answerButtons[i].GetComponentInChildren<TMP_Text>().text=JsonReader.Instance.questionList.results[selectedQuestion]
                    .incorrect_answers[b];
                b++;
            }
        }
        
    }

    void Update()
    {
    }

    void ButtonClick()
    {
        
    }
}
