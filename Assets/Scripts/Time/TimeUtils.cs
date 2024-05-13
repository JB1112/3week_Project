using System;
using TMPro;
using UnityEngine;

public class TimeUtils : MonoBehaviour
{
    public TextMeshProUGUI nowTime;
    private void Update()
    {
        nowTime.text = DateTime.Now.ToString(("tt HH:mm"));
    }
}