# ReadArkData

这是一个明日方舟游戏数据专用的角色台词查找器，可以查找某一位在原作故事中出现的角色的所有台词以及来源(如：SideStory-骑兵与猎人，)。

- **注意**：在使用本仓库前请先在本地任意位置clone或者下载[明日方舟游戏数据](https://github.com/Kengxxiao/ArknightsGameData)。

使用指南：
在下载好的[ArknightsGameData](https://github.com/Kengxxiao/ArknightsGameData)仓库中，找到story文件夹(路径为"ArknightsGameData\zh_CN\gamedata\story")，
并将story文件夹的**绝对路径**覆盖到此文件夹下storyFolderPath.txt的**第一行**。如（这只是我电脑上的绝对路径，务必更换）：
```
D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story
```

之后即可在终端运行：
```
cd bin\Debug\net9.0
./ReadArkData.exe
```
运行示例：
```
Target path: D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story
Activities path: D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story\activities
Obt path: D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story\obt
Enter the name of your output txt (without back name    .txt):
Kal'tsit
Need simplified output? (only dialogs, not recommended.) (y/n)
n
Output file path: D:\MyProjects\ReadArkData\bin\Debug\net9.0\Output\Kal'tsit.txt
Total number of found target files: 2855
Searching character name(Use Simplified Chinese):
凯尔希
Done! The output file is saved at: D:\MyProjects\ReadArkData\bin\Debug\net9.0\Output\Kal'tsit.txt
```

之后在`ReadArkData\bin\Debug\net9.0\Output`即可找到生成的`.txt`文件。
注意：*简化模式输出*将输出纯文本，不包含文本来源信息，(也许)可以用于llm分析，默认不开启。




*（注：晚上不想睡觉时做的玩的，所以这东西到底有什么用）*