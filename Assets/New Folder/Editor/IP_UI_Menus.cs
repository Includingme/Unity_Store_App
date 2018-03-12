using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Basic.UI
{
    public class IP_UI_Menus : MonoBehaviour
    {
        [MenuItem("Basic.UI/UI Tools/Create UI Group")]
        public static void CreateUIGroup()
        {
            GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/New Folder/Prefab/UI_GRP.prefab");

                if(uiGroup)
            {
                GameObject createdGroup = (GameObject)Instantiate(uiGroup);
                createdGroup.name = "UI_GRP";
            }
                else
            {
                EditorUtility.DisplayDialog("UI Tools Warning", "Cannot find UI Group Prefab", "OK");
            }
        }
    }
}
