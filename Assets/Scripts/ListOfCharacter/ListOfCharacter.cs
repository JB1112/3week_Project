using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ListOfCharacter :MonoBehaviour
{
    public TextMeshProUGUI NameTxt;
    private Text Character;
    private List<String> CharacterList = new List<String>();

    private void Start()
    {
        Character = GameObject.Find("ListOfCharacter").GetComponent<Text>();
    }
    private void Update()
    {
        CharacterList.Clear();
        CharacterList.Add(NameTxt.text);
        CharacterList.Add("aaa"); //����Ʈ �Է� �۵� �� �Ǵ��� �׽�Ʈ
        CharacterList.Add("bbb");
        SetText();
    }

    private void SetText()
    {
        String Txt = "���\n";
        for (int i = 0; i < CharacterList.Count; i++)
        {
            Txt += CharacterList[i] + "\n";
        }
        Character.text = Txt;
    }
}