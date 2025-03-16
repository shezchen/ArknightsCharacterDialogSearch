# Arknights Character Dialog Search

这是一个明日方舟游戏数据专用的角色台词查找器，可以查找某一位在原作故事中出现的角色的所有台词以及来源(如：SideStory-骑兵与猎人)。
包含所有主题曲，SideStory，故事集，活动剧情和集成战略结局剧情。

- **注意：在使用本仓库前请先在本地任意位置clone或者下载[明日方舟游戏数据（点击链接）](https://github.com/Kengxxiao/ArknightsGameData)!!!**
- *(其实也可以只下载story文件夹)*

使用指南：
在下载好的[ArknightsGameData](https://github.com/Kengxxiao/ArknightsGameData)仓库中，找到story文件夹(路径为"ArknightsGameData\zh_CN\gamedata\story")，
并将story文件夹的**绝对路径**覆盖到此文件夹下storyFolderPath.txt的**第一行**。如（这只是我电脑上的绝对路径，务必更换）：
```
D:\c_sharp_repo\ArknightsGameData\zh_CN\gamedata\story
```

之后即可在终端运行(或者自行编译，如果你使用Macos等)：
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
生成的数据(仅截取一部分)
```
SideStory-骑兵与猎人
----------------------------------------
你回来了。
现在你是想通了，还是怎么？
你私自出动了。
我不干涉干员的私事，也不会过问他们做了些什么，只要他们没有损害罗德岛的利益。
希望你的行为不要有失你在罗德岛的身份，斯卡蒂。
你想要从我这里换到什么？
我所拥有的信息的价值，真有这么轻贱？
但我知道你假称任务，去了卡西米尔的滴水村，还和其他干员发生了冲突。
那个孩子无论是在滴水村还是在罗德岛，都替你保守了秘密。但我绝没有向你发布过任何类似的任务。
嗯？血已经注满了融芯。这不是你的血，你不敢在大地上流血。
你已经做了这种事。
你和你的种群让我感到可笑，我并不依赖任何一个零件去拼凑出大地的全貌。
你与罗德岛由契约相连，你与我也当如是。
难得看见你恼怒的样子。只有在这种时候，你才会一改平常的慵懒和颓废。

......(此处省略5000+行)
```
之后在`ReadArkData\bin\Debug\net9.0\Output`即可找到生成的`.txt`文件。
注意：*简化模式输出*将输出纯文本，不包含文本来源信息，(也许)可以用于llm分析，默认不开启。




*（注：晚上不想睡觉时做的玩的，所以这东西到底有什么用）*