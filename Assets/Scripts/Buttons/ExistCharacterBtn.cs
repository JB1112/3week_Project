using UnityEngine;
using UnityEngine.UI;

public class ExistCharacterBtn : MonoBehaviour
{
    public GameObject sideTab;

    public void OpenSideTab()
    {
        if(sideTab.activeSelf == true)
        {
            sideTab.SetActive(false);
        }
        else if(sideTab.activeSelf == false)
        {
            sideTab.SetActive(true);
        }
    }
}