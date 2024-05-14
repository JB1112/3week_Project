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
        CharacterList.Add("Muddy"); //리스트 입력 작동 잘 되는지 테스트
        CharacterList.Add("bbb");
        /*Set List*/
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
    
    /*private void SetList()
    {
        CharacterList.Clear();
        CharacterList.Add(NameTxt.text);
        for(int i = 0;i < NPCList.Count;i++)
        {
            CharacterList.Add(NPCList[i]);
        }
    }*/
    //NPC가 다수라면 리스트를 작성 후 끌어오는 방식 채용
}