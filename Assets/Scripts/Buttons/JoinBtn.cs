using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JoinBtn :MonoBehaviour
{
    public InputField nameTxt;
    public TextMeshProUGUI characterNameTxt;
    public Button joinBtn;
    public GameObject Canvas;

    private void Start()
    {

    }

    private void Update()
    {
        if(nameTxt.text.Length <2 || nameTxt.text.Length > 10)
        {
            joinBtn.interactable = false;
        }
        else
        {
            joinBtn.interactable = true;
        }
    }

    public void JoinGame()
    {
        Canvas.SetActive(false);

        characterNameTxt.text = nameTxt.text;
    }
}