using Sirenix.OdinInspector;
using UnityEngine;

public class MyWindowSettings : ScriptableObject
{
    public int TargetFPS = 30;

    [Button]
    public void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.LogError("Cleared Playerprefs");
    }


    public void Init(MyEditorWindow window)
    {
        TargetFPS = window.TargetFPS;
    }

    public void ApplySettings(MyEditorWindow window)
    {
        window.TargetFPS = TargetFPS;
        window.Repaint();
    }
}
