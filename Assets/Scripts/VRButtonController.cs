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
        // Butona t�klan�nca yap�lacak i�lemi buraya yaz�n
        Debug.Log("Button Clicked");
    }
}
