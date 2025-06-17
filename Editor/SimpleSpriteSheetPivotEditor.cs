using UnityEngine;
using UnityEditor;

public class SimpleSpriteSheetPivotEditor : EditorWindow
{
    private Texture2D targetTexture;
    private float pivotX = 0.5f;
    private float pivotY = 0.3f;
    
    [MenuItem("Tools/Simple Sprite Pivot Editor")]
    public static void ShowWindow()
    {
        GetWindow<SimpleSpriteSheetPivotEditor>("简易精灵轴心点编辑器");
    }
    
    private void OnGUI()
    {
        GUILayout.Label("简易精灵轴心点编辑器", EditorStyles.boldLabel);
        EditorGUILayout.Space();
        
        targetTexture = (Texture2D)EditorGUILayout.ObjectField("目标精灵表", targetTexture, typeof(Texture2D), false);
        
        EditorGUILayout.Space();
        
        pivotX = EditorGUILayout.Slider("轴心点 X", pivotX, 0f, 1f);
        pivotY = EditorGUILayout.Slider("轴心点 Y", pivotY, 0f, 1f);
        
        EditorGUILayout.Space();
        
        if (GUILayout.Button("设置轴心点"))
        {
            if (targetTexture != null)
            {
                try
                {
                    ApplyPivot();
                    EditorUtility.DisplayDialog("成功", "轴心点设置已应用", "确定");
                }
                catch (System.Exception e)
                {
                    EditorUtility.DisplayDialog("错误", "设置轴心点时出错: " + e.Message, "确定");
                    Debug.LogError("设置轴心点时出错: " + e.Message);
                }
            }
            else
            {
                EditorUtility.DisplayDialog("错误", "请先选择一个精灵表", "确定");
            }
        }
    }
    
    private void ApplyPivot()
    {
        string path = AssetDatabase.GetAssetPath(targetTexture);
        TextureImporter importer = AssetImporter.GetAtPath(path) as TextureImporter;
        
        if (importer == null)
            throw new System.Exception("无法获取TextureImporter");
            
        if (importer.spriteImportMode != SpriteImportMode.Multiple)
            throw new System.Exception("精灵表必须设置为Multiple模式");
            
        SpriteMetaData[] spritesheet = importer.spritesheet;
        
        for (int i = 0; i < spritesheet.Length; i++)
        {
            SpriteMetaData metaData = spritesheet[i];
            metaData.alignment = (int)SpriteAlignment.Custom;
            metaData.pivot = new Vector2(pivotX, pivotY);
            spritesheet[i] = metaData;
        }
        
        importer.spritesheet = spritesheet;
        
        AssetDatabase.StartAssetEditing();
        try
        {
            EditorUtility.SetDirty(importer);
            importer.SaveAndReimport();
        }
        finally
        {
            AssetDatabase.StopAssetEditing();
        }
    }
}