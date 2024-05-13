using UnityEngine;

public class ChangeCharacterBtn : MonoBehaviour
{
    public GameObject CharacterSelectPanel;

    public void OpenCharacterSelectPanel()
    {
        CharacterSelectPanel.SetActive(true);
    }
}
