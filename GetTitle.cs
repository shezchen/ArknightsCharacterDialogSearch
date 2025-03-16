using System.Text.RegularExpressions;

namespace ReadArkData;

public static class GetTitle
{
    public static string getTitle(string file)
    {
        if(file.Contains(@"story\activities\a001\"))
            return "SideStory-骑兵与猎人";
        if(file.Contains(@"story\activities\act1arcade\"))
            return "Activity-视相博物馆";
        if(file.Contains(@"story\activities\act1sandbox\"))
            return "生息演算-沙洲遗闻";
        if(file.Contains(@"story\activities\act1vautochess\"))
            return "卫戍协议";
        if(file.Contains(@"story\activities\act2vmulti\"))
            return "促融共竞";
        if(file.Contains(@"story\activities\act3d0\"))
            return "SideStory-火蓝之心";
        if(file.Contains(@"story\activities\act3fun\"))
            return "Activity-狂弹要塞！罗德大兵集结！";
        if(file.Contains(@"story\activities\act4d0\"))
            return "故事集-战地秘闻";
        if(file.Contains(@"story\activities\act4fun\"))
            return "Activity-主播U-全能系美少女";
        if (file.Contains(@"story\activities\act5d0\"))
            return "SideStory-喧闹法则";
        if(file.Contains(@"story\activities\act5d1\"))
            return "危机合约#0";
        if(file.Contains(@"story\activities\act5fun\"))
            return "Activity-好得不能再好了！泰拉投资大师课";
        if(file.Contains(@"story\activities\act6d5\"))
            return "故事集-洪炉示岁";
        if (file.Contains(@"story\activities\act7d5\"))
            return "故事集-午间逸话";
        if (file.Contains(@"story\activities\act7mini\"))
            return "故事集-灯火序曲";
        if (file.Contains(@"story\activities\act8mini\"))
            return "故事集-如我所见";
        if (file.Contains(@"story\activities\act9d0\"))
            return "SideStory-生于黑夜";
        if (file.Contains(@"story\activities\act9mini\"))
            return "故事集-红松林";
        if(file.Contains(@"story\activities\act10d5\"))
            return "故事集-乌萨斯的孩子们";
        if(file.Contains(@"story\activities\act10mini\"))
            return "故事集-阴云火花";
        if (file.Contains(@"story\activities\act11d0\"))
            return "SideStory-沃伦姆德的薄暮";
        if (file.Contains(@"story\activities\act11d7\"))
            return "SideStory-火蓝之心(复刻)";
        if (file.Contains(@"story\activities\act11mini\"))
            return "故事集-未尽篇章";
        if (file.Contains(@"story\activities\act12d0\"))
            return "SideStory-密林悍将归来";
        if (file.Contains(@"story\activities\act12d6\"))
            return "Activity-刻俄柏的灰蔁迷境";
        if (file.Contains(@"story\activities\act12mini\"))
            return "故事集-日暮寻路";
        if (file.Contains(@"story\activities\act12side\"))
            return "SideStory-多索雷斯假日";
        if (file.Contains(@"story\activities\act13d0\"))
            return "故事集-踏寻往昔之风";
        if(file.Contains(@"story\activities\act13d5\"))
            return "SideStory-玛莉娅 临光";
        if(file.Contains(@"story\activities\act13mini\"))
            return "故事集-好久不见";
        if (file.Contains(@"story\activities\act13side\"))
            return "SideStory-长夜临光";
        if (file.Contains(@"story\activities\act14mini\"))
            return "故事集-春分";
        if (file.Contains(@"story\activities\act14side\"))
            return "SideStory-风雪过境";
        if (file.Contains(@"story\activities\act15d0\"))
            return "SideStory-孤岛风云";
        if (file.Contains(@"story\activities\act15d5\"))
            return "故事集-此地之外";
        if (file.Contains(@"story\activities\act15mini\"))
            return "故事集-眠于树影之中";
        if (file.Contains(@"story\activities\act15side\"))
            return "SideStory-将进酒";
        if (file.Contains(@"story\activities\act16d5\"))
            return "SideStory-画中人";
        if(file.Contains(@"story\activities\act16mini\"))
            return "故事集-去咧嘴谷";
        if (file.Contains(@"story\activities\act16side\"))
            return "SideStory-吾导先路";
        if (file.Contains(@"story\activities\act17d0\"))
            return "SideStory-源石尘行动";
        if (file.Contains(@"story\activities\act17d1\"))
            return "Activity-罗德岛防御协议";
        if(file.Contains(@"story\activities\act17d7\"))
            return "Activity-泰拉说唱之夜";
        if(file.Contains(@"story\activities\act17mini\"))
            return "故事集-熔炉\"还魂\"记";
        if (file.Contains(@"story\activities\act17side\"))
            return "SideStory-愚人号";
        if (file.Contains(@"story\activities\act18d0\"))
            return "SideStory-遗尘漫步";
        if (file.Contains(@"story\activities\act18d3\"))
            return "SideStory-覆潮之下";
        if (file.Contains(@"story\activities\act18mini\"))
            return "故事集-我们明天见";
        if (file.Contains(@"story\activities\act18side\"))
            return "SideStory-尘影余音";
        if (file.Contains(@"story\activities\act19side\"))
            return "SideStory-绿野幻梦";
        if (file.Contains(@"story\activities\act20side\"))
            return "SideStory-理想城：长夏狂欢季";
        if (file.Contains(@"story\activities\act21side\"))
            return "SideStory-叙拉古人";
        if (file.Contains(@"story\activities\act22side\"))
            return "SideStory-照我以火";
        if (file.Contains(@"story\activities\act23side\"))
            return "SideStory-登临意";
        if (file.Contains(@"story\activities\act24side\"))
            return "SideStory-落叶逐火";
        if (file.Contains(@"story\activities\act25side\"))
            return "SideStory-孤星";
        if (file.Contains(@"story\activities\act26side\"))
            return "SideStory-空想花庭";
        if (file.Contains(@"story\activities\act27side\"))
            return "SideStory-火山旅梦";
        if (file.Contains(@"story\activities\act28side\"))
            return "SideStory-不义之财";
        if (file.Contains(@"story\activities\act29side\"))
            return "SideStory-崔林特尔梅之金";
        if (file.Contains(@"story\activities\act30side\"))
            return "SideStory-银心湖列车";
        if (file.Contains(@"story\activities\act31side\"))
            return "SideStory-怀黍离";
        if (file.Contains(@"story\activities\act32side\"))
            return "SideStory-水晶箭行动";
        if (file.Contains(@"story\activities\act33side\"))
            return "SideStory-巴别塔";
        if (file.Contains(@"story\activities\act34side\"))
            return "SideStory-生路";
        if (file.Contains(@"story\activities\act35side\"))
            return "SideStory-太阳甩在身后";
        if (file.Contains(@"story\activities\act36side\"))
            return "SideStory-泰拉饭";
        if (file.Contains(@"story\activities\act37side\"))
            return "SideStory-追迹日落以西";
        if (file.Contains(@"story\activities\act38d1\"))
            return "危机合约-尖灭测试作战";
        if (file.Contains(@"story\activities\act38side\"))
            return "SideStory-揭幕者们";
        if (file.Contains(@"story\activities\act39side\"))
            return "SideStory-出苍白海";
        if (file.Contains(@"story\activities\act40side\"))
            return "SideStory-相见欢";
        if (file.Contains(@"story\activities\act41side\"))
            return "SideStory-挽歌燃烧殆尽";
        if (file.Contains(@"story\obt\"))
        {
            string fileName = Path.GetFileNameWithoutExtension(file);
            string pattern = @"\d+-\d+";
            Match match = Regex.Match(fileName, pattern);
            if (match.Success)
            {
                return "主题曲 " + $"{match.Value}";
            }else
            {
                return "";
            }
        }

        return "";
    }
}