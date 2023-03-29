using System;
using UnityEditor;

namespace MYSDK.Editor
{
    public class MyEditorWindow : EditorWindow
    {
        [MenuItem("MYSDK/OpenWin")]
        static void OpenWin()
        {
            MyEditorWindow mywin = EditorWindow.GetWindow<MyEditorWindow>();
            mywin.Show();
        }
    }
}
