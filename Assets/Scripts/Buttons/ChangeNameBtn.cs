using UnityEngine;
using UnityEngine.UI;

public class ChangeNameBtn : MonoBehaviour
{
    public GameObject changeNamePanel;
    public InputField changeNameTxt;

    public void ChangeName()
    {
        changeNameTxt.text = null;
        changeNamePanel.SetActive(true);
    }
}
