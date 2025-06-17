using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject ganhouCanvas;
    [SerializeField] private GameObject perdeuCanvas;
    [SerializeField] private GameObject jogoCanvas;

    private int totalItensColocados = 0;
    private int totalItensCorretos = 0;
    private bool jogoTerminado = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (jogoTerminado) return;

        GameObject dropped = eventData.pointerDrag;

        if (dropped == null) return;

        dropped.SetActive(false); // Desativa o item
        totalItensColocados++;

        if (dropped.name == "Certo1" || dropped.name == "Certo2" || dropped.name == "Certo3")
        {
            totalItensCorretos++;
        }

        if (totalItensColocados == 3)
        {
            jogoTerminado = true;

            if (totalItensCorretos == 3)
            {
                Debug.Log("Ganhou!");
                ganhouCanvas.SetActive(true);
            }
            else
            {
                Debug.Log("Perdeu!");
                perdeuCanvas.SetActive(true);
            }

            jogoCanvas.SetActive(false);
        }
    }
}
