namespace ReadArkData;
using System.IO;
using System.Collections.Generic;
public class TargetFilesFinder
{
    public void FindTargetFiles(string sourcePath, List<string> targetFiles)
    {
        
        string[] files = Directory.GetFiles(sourcePath);
        foreach (var file in files)
        {
            if (file.EndsWith(".txt"))
            {
                targetFiles.Add(file);
            }
        }
        
        // 获取所有子文件夹的绝对路径
        string[] subDirectories = Directory.GetDirectories(sourcePath);
        
        if(subDirectories.Length == 0)
        {
            return;
        }

        foreach (var subDirectory in subDirectories)
        {
            FindTargetFiles(subDirectory, targetFiles);
        }
    }
    
}