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
        CharacterList.Add("Muddy"); //����Ʈ �Է� �۵� �� �Ǵ��� �׽�Ʈ
        CharacterList.Add("bbb");
        /*Set List*/
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
    
    /*private void SetList()
    {
        CharacterList.Clear();
        CharacterList.Add(NameTxt.text);
        for(int i = 0;i < NPCList.Count;i++)
        {
            CharacterList.Add(NPCList[i]);
        }
    }*/
    //NPC�� �ټ���� ����Ʈ�� �ۼ� �� ������� ��� ä��
}