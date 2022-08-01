using TMPro;
using UnityEngine;

public class UILifeController : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI currentLifeUIText;

    public void ShowCurrentLife(int currentLife)
    {
        currentLifeUIText.SetText(currentLife.ToString());
    }
}
