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
        CharacterList.Add("aaa"); //리스트 입력 작동 잘 되는지 테스트
        CharacterList.Add("bbb");
        SetText();
    }

    private void SetText()
    {
        String Txt = "목록\n";
        for (int i = 0; i < CharacterList.Count; i++)
        {
            Txt += CharacterList[i] + "\n";
        }
        Character.text = Txt;
    }
}