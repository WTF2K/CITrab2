
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalSceneManagerQuiz : MonoBehaviour
{
    [SerializeField]
    private TMP_Text rightAnswersText;
    [SerializeField]
    private TMP_Text wrongAnswersText;
    public void Start()
    {
        rightAnswersText.text = GameManagerQuiz.GetRightAnswer().ToString();
        wrongAnswersText.text = GameManagerQuiz.GetWrongAnswer().ToString();
    }
    public void TestAgain()
    {
        GameManagerQuiz.Reset();
        SceneManager.LoadScene("NiveisQuiz");
    }
}
