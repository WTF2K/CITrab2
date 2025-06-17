using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    private enum RightAnswerPossibility
    {
        Btn1,
        Btn2,
        Btn3
    }

    [SerializeField]
    private RightAnswerPossibility rightAnswer;
    public string nextQuestionSceneName;

    public void OnButtonClick()
    {
        var clickedItemName = EventSystem.current.currentSelectedGameObject.name;
        if (clickedItemName == rightAnswer.ToString())
        {
            GameManager.IncrementRightAnswer(); 
            SceneManager.LoadScene(nextQuestionSceneName);
            return;
        }
        GameManager.IncrementWrongAnswer(); 
        SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
    }
}