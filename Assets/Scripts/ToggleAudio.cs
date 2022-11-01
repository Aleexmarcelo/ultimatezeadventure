using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{

    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
