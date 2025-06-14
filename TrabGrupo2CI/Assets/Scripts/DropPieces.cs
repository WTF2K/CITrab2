using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DropPieces : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private AudioSource correctSound;  // Áudio para som de acerto

    [SerializeField]
    private AudioSource wrongSound;  // Áudio para som de erro

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;
        var collisionElement = eventData.pointerDrag.GetComponent<PuzzlePiece>();
        if (collisionElement == null) return;
        if (collisionElement.targetImage.name == this.gameObject.name)
        {
            var currentColor = this.GetComponent<Image>().color;
            currentColor.a = 1;
            GetComponent<Image>().color = currentColor;


            Destroy(collisionElement.gameObject, 0);
            GameManager.IncrementRightAnswer();
            correctSound.Play();  // Toca o som de acerto
        }

        else
        {

            collisionElement.ResetImage();
            GameManager.IncrementWrongAnswer();
            wrongSound.Play();  // Toca o som de erro
        }
    }
}
