using UnityEngine;

public class ConversationBtn : MonoBehaviour
{
    public GameObject MuddySays;

    public void Says()
    {
        if (MuddySays.activeSelf == true)
        {
            MuddySays.SetActive(false);
        }
        else if (MuddySays.activeSelf == false)
        {
            MuddySays.SetActive(true);
        }
    }
}