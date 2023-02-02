using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandle : MonoBehaviour
{
    enum Choices
    {
        A,B, C, D
    }

    public void ButtonClick()
    {
        int buttonIndex=0;

       if(gameObject.tag=="A") buttonIndex=(int)Choices.A;
       if(gameObject.tag=="B") buttonIndex=(int)Choices.B;
       if(gameObject.tag=="C") buttonIndex=(int)Choices.C;
       if(gameObject.tag=="D") buttonIndex=(int)Choices.D;

        if(LevelManager.Instance.answerButtons[buttonIndex].GetComponentInChildren<TMPro.TMP_Text>().text==
            JsonReader.Instance.questionList.results[LevelManager.Instance.selectedQuestion].correct_answer)
        {
           LevelManager.Instance.answerButtons[buttonIndex].image.color=Color.green;
            Playerscript.instance.win = true;
        }
        else
        {
            
        }
    }
}
