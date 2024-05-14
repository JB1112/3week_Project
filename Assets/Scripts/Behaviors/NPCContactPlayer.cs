using UnityEngine;

public class NPCContactPlayer :MonoBehaviour
{
    [SerializeField][Range(0f, 100f)] private float recognizeDistance;
    public GameObject player;
    public GameObject NPCMessagePanel;
    public GameObject MuddySays;

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < recognizeDistance && MuddySays.activeSelf == false)
        {
            NPCMessagePanel.SetActive(true);
        }
        else
        {
            NPCMessagePanel.SetActive(false);
        }
    }
}