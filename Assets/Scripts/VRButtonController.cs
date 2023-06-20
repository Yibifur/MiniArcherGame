using UnityEngine;
using UnityEngine.UI;

public class VRButtonController : MonoBehaviour
{
    public Button vrButton;

    private void Start()
    {
        vrButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // Butona týklanýnca yapýlacak iþlemi buraya yazýn
        Debug.Log("Button Clicked");
    }
}
