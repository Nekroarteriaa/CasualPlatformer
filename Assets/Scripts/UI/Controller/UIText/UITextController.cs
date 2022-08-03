using TMPro;
using UnityEngine;

namespace UI.Controller.UIText
{
    public class UITextController : MonoBehaviour
    {
        [SerializeField] 
        private TextMeshProUGUI textValue;

        public void OnCurrentUITextValueChanged(int newValue)
        {
            textValue.SetText(newValue.ToString());
        }
    }
}
