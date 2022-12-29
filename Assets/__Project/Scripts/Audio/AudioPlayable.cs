using UnityEngine;


public abstract class AudioPlayable : ScriptableObject
{
    public abstract void Play();
    public abstract void Pause();
    public abstract void Stop();
    public abstract void Restart();
}
