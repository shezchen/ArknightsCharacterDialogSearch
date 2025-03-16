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
        string storyFolderPath = File.ReadLines($@"{Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName,"storyFolderPath.txt")}").First();
        string activitiesPath = Path.Combine(storyFolderPath , "activities");   
        string obtPath = Path.Combine(storyFolderPath , "obt");
        
        if(storyFolderPath == "")
        {
            Console.WriteLine("Error: Please enter the path to the \"story\" folder.");
            return;
        }
        else
        {
            Console.WriteLine($"Target path: {storyFolderPath}");
            Console.WriteLine($"Activities path: {activitiesPath}");
            Console.WriteLine($"Obt path: {obtPath}");
        }
        
        Console.WriteLine("Enter the name of your output txt (without .txt):");
        string TXTname = Console.ReadLine() ?? "output";
        
        Console.WriteLine("Need simplified output? (only dialogs, not recommended.) (y/n)");
        string needSimplifed = Console.ReadLine() ?? "n";
        if(needSimplifed == "y" || needSimplifed  == "Y")
        {
            state = State.simplifed;
        }
        
        // 输出文件路径
        string outputFilePath = Path.Combine(Environment.CurrentDirectory,TXTname+".txt");
        
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            Console.WriteLine($"Output file path: {outputFilePath}");
            
            List<string> targetFiles = new List<string>();
            
            TargetFilesFinder finder = new TargetFilesFinder();
            
            finder.FindTargetFiles(activitiesPath, targetFiles);
            finder.FindTargetFiles(obtPath, targetFiles);
            
            Console.WriteLine($"Total number of found target files: {targetFiles.Count}");

            Console.WriteLine("Searching character name(Use Simplified Chinese):");
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