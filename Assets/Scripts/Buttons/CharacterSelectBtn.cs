using UnityEngine;

public class CharacterSelectBtn: MonoBehaviour
{
    public GameObject Knight;
    public GameObject Wizard;
    public GameObject CharatcerSelectPanel;
    public GameObject WizardImg;
    public GameObject KnightImg;

    public void SelectWizardBtn()
    {
        CharatcerSelectPanel.SetActive(false);
        if (KnightImg.activeSelf == true)
        {
            KnightImg.SetActive(false);
            Knight.SetActive(false);
        }
        WizardImg.SetActive(true);
        Wizard.SetActive(true) ;

    }
    public void SelectKnightBtn()
    {
        CharatcerSelectPanel.SetActive(false);
        if (WizardImg.activeSelf == true)
        {
            WizardImg.SetActive(false);
            Wizard.SetActive(false);
        }
        KnightImg.SetActive(true);
        Knight.SetActive(true);
    }
}
