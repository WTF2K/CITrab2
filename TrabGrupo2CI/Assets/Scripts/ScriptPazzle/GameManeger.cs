using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    private static int _rightAnswers = 0;
    private static int _wrongAnswers = 0;
    private static int _targetRightAnswers = 0;  // Змінна для цільової кількості правильних відповідей

    // Метод для встановлення цілі — скільки правильних відповідей потрібно
    public static void SetTargetRightAnswers(int count)
    {
        _targetRightAnswers = count;
        Reset();  // Скидаємо лічильники при зміні рівня
        Debug.Log($"GameManager: Ціль правильних відповідей встановлено = {_targetRightAnswers}");
    }

    public static void IncrementRightAnswer()
    {
        _rightAnswers++;
        Debug.Log($"GameManager: Правильних відповідей {_rightAnswers} з {_targetRightAnswers}");

        if (_rightAnswers >= _targetRightAnswers && _targetRightAnswers > 0)
        {
            Debug.Log("GameManager: Завантаження фінальної сцени...");
            SceneManager.LoadScene("FinalPazzle");
        }
    }

    public static void IncrementWrongAnswer()
    {
        _wrongAnswers++;
    }

    public static void Reset()
    {
        _rightAnswers = 0;
        _wrongAnswers = 0;
    }

    public static int GetRightAnswers()
    {
        return _rightAnswers;
    }

    public static int GetWrongAnswers()
    {
        return _wrongAnswers;
    }
}
