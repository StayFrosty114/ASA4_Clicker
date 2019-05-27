using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SC_SoundController : MonoBehaviour
{
    // Grabs an audio clip from unity
    public AudioClip sound;

    // Gets the required components of the attached object.
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());


    }

    // Plays the sound once on click.
    void PlaySound()
    {
        source.PlayOneShot(sound);
    }
}
