using UnityEngine;

public class LevelInit : MonoBehaviour
{
    [SerializeField]
    private int targetRightAnswers = 0;

    private void Awake()
    {
        GameManager.Reset();
        GameManager.SetTargetRightAnswers(targetRightAnswers);
    }
}
