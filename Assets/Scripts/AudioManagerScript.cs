using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound, coinSound, meyveSound;
    public static AudioSource audioSrc;
    private void Start() {
        jumpSound = Resources.Load<AudioClip> ("jump");
        coinSound = Resources.Load<AudioClip> ("coin");
        //meyveSound = Resources.Load<AudioClip> ("MeyveToplama");
        meyveSound = (AudioClip)Resources.Load ("Assets/Sounds/Effects/MeyveToplama");
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update() {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jump":
            audioSrc.PlayOneShot (jumpSound);
            break;
            case "coin":
            audioSrc.PlayOneShot (coinSound);
            break;
            case "MeyveToplama":
            audioSrc.PlayOneShot (meyveSound);
            break;
        }
    }
}
