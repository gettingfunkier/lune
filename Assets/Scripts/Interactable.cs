using UnityEngine;

public class Interactable : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Interactable clicked: " + gameObject.name);
    }
}
