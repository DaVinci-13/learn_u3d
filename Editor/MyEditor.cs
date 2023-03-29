using UnityEditor;
using UnityEngine;

namespace MYSDK.Editor
{
    public class MyEditor : UnityEditor.Editor
    {
        [MenuItem("MYSDK/Excute")]
        static void Excute()
        {
            Debug.Log("Hello World!");
        }
       
    }
}
