using EUI;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip newMusic;

    private void OnEnable()
    {
        MenuManager.ins.changeMusic(newMusic);
    }

}
