using System.Text.RegularExpressions;

namespace ReadArkData;

//text:
//D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story
//凯尔希

class Program
{
    enum State
    {
        df,
        simplifed,
    }
    static void Main(string[] args)
    {
        State state = State.df;
        string activitiesPath = "";
        string obtPath = "";
        Console.WriteLine("Example : D:\\ArknightsGameData\\zh_CN\\gamedata\\story" );
        Console.WriteLine("Enter the path to the \"story\" folder:");
        activitiesPath = Console.ReadLine() ?? "";
        if(activitiesPath == "")
        {
            Console.WriteLine("Error: Please enter the path to the \"story\" folder.");
            return;
        }
        
        
        obtPath = Path.Combine(activitiesPath , "obt");
        activitiesPath = Path.Combine(activitiesPath , "activities");        
        
        Console.WriteLine("Enter the name of out put txt:");
        string TXTname = Console.ReadLine() ?? "output";
        
        Console.WriteLine("Need Simplified output? (y/n)");
        string needSimplifed = Console.ReadLine() ?? "n";
        if(needSimplifed == "y" || needSimplifed  == "Y")
        {
            state = State.simplifed;
        }
        
        // 输出文件路径
        string outputFilePath = Path.Combine(Environment.CurrentDirectory,TXTname+".txt");
        
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            Console.WriteLine($"文件创建成功，位置在: {outputFilePath}");
            
            List<string> targetFiles = new List<string>();
            
            TargetFilesFinder finder = new TargetFilesFinder();
            
            finder.FindTargetFiles(activitiesPath, targetFiles);
            finder.FindTargetFiles(obtPath, targetFiles);
            
            Console.WriteLine($"Total number of found target files: {targetFiles.Count}");

            Console.WriteLine("Searching character name:");
            //[name="可露希尔"]
            string targetCharacterName = $"[name=\"{Console.ReadLine() ?? "阿米娅"}\"]";
            string characterNamePattern = @"\[name=""[^""]*""\]\s*(.*)";

            int i = -1;
            foreach (var targetFile in targetFiles)
            {
                i++;
                bool found = false;
                
                string[] content = File.ReadAllLines(targetFile);

               

                foreach (var line in content)
                {
                    if (line.Contains(targetCharacterName))
                    {
                        string outputLine = "";
                        Match match = Regex.Match(line, characterNamePattern);
                        if (match.Success)
                            outputLine = match.Groups[1].Value;

                        if (!found)
                        {
                            found = true;
                            if (state == State.df)
                            {
                                string title = GetTitle.getTitle(targetFile);
                                writer.WriteLine($"{title}");
                                writer.WriteLine(@"----------------------------------------");
                            }
                        }

                        writer.WriteLine(outputLine);
                    }
                }

                if (found == true && state == State.df)
                {
                    writer.WriteLine(@"-------------------END------------------");
                    writer.WriteLine();
                }
            }
            
            Console.WriteLine($"Done! The output file is saved at: {outputFilePath}");
        }
        
    }
}