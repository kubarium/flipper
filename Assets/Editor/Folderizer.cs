using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Folderizer : EditorWindow
{

	[MenuItem("Assets/Folderize", false, 21)]
	static void Folderize()
	{	
		
		string settingFilePath = EditorUtility.OpenFilePanel("Select your folderize file", "", "txt");
		if (settingFilePath.Length > 0) {
			ArrayList entries = new ArrayList(File.ReadAllLines(Path.GetFullPath(settingFilePath)));
			entries.Sort();


			foreach (string entry in entries) {
				if (!Directory.Exists("Assets/" + entry)) {
					Directory.CreateDirectory("Assets/" + entry);
				}				
			}
			AssetDatabase.Refresh();
		}
	}

}
