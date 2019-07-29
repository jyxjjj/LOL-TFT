using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL_TFT
{
    public class 装备
    {
        public static string 暴风大剑 { get { return "暴风大剑\r\n+20 攻击力"; } }
        public static string 反曲之弓 { get { return "反曲之弓\r\n+20% 攻击速度"; } }
        public static string 无用大棒 { get { return "无用大棒\r\n+20% 技能伤害"; } }
        public static string 女神之泪 { get { return "女神之泪\r\n+20 法力值"; } }
        public static string 巨人腰带 { get { return "巨人腰带\r\n+200 生命值"; } }
        public static string 锁子甲 { get { return "锁子甲\r\n+20 护甲"; } }
        public static string 负极斗篷 { get { return "负极斗篷\r\n+20 魔法抗性"; } }
        public static string 金铲铲 { get { return "金铲铲\r\n它必须做点什么"; } }
        public static string 暗裔 { get { return "暗裔\r\n+40 法力值\r\n携带者也是一个恶魔"; } }
        public static string 冰霜之锤 { get { return "冰霜之锤\r\n+400 生命值\r\n携带者也是一名极地生物"; } }
        public static string 冰霜之心 { get { return "冰霜之心\r\n+20 法力值 +20 护甲\r\n临近的敌人降低 20% 攻击速度"; } }
        public static string 炽天使之拥 { get { return "炽天使之拥\r\n+20 法力值 +20 法力值\r\n每次施放技能后恢复自身 20% 法力"; } }
        public static string 守护天使 { get { return "守护天使\r\n+20 攻击力 +20 护甲\r\n阵亡2秒后可复活，复活后具有 1000 生命值"; } }
        public static string 钢铁烈阳之匣 { get { return "钢铁烈阳之匣\r\n+20% 技能伤害 +20 护甲\r\n战斗开始前，为持有者及其左右两格内的英雄施加一个 200 点的护盾"; } }
        public static string 鬼索的狂暴之刃 { get { return "鬼索的狂暴之刃\r\n+20% 攻击速度 +20% 技能伤害\r\n每次普攻增加 4% 攻击速度，可无限叠加"; } }
        public static string 海克斯科技枪刃 { get { return "海克斯科技枪刃\r\n+20 攻击力 +20% 技能伤害\r\n+25% 全能吸血"; } }
        public static string 幻影之舞 { get { return "幻影之舞\r\n+20% 攻击速度 +20 护甲\r\n携带者闪避所有暴击"; } }
        public static string 基克的先驱 { get { return "基克的先驱\r\n+20 攻击力 +200 生命值\r\n为持有者左右两格内的英雄提供 15% 攻速"; } }
        public static string 疾射火炮 { get { return "疾射火炮\r\n+20% 攻击速度 +20% 攻击速度\r\n携带者的攻击不会被闪避，攻击距离翻倍"; } }
        public static string 荆棘之甲 { get { return "荆棘之甲\r\n+20 护甲 +20 护甲\r\n对攻击者造成自我缓和伤害的 100% 的真实伤害"; } }
        public static string 救赎 { get { return "救赎\r\n+20 法力值 +200生命值\r\n在 25% 生命值时，治疗附近所有友军 1000 点生命值"; } }
        public static string 巨龙之爪 { get { return "巨龙之爪\r\n+20 魔法抗性 +20 魔法抗性\r\n装备者提供 83% 魔法抗性"; } }
        public static string 巨型九头蛇 { get { return "巨型九头蛇\r\n+20% 攻击速度 +200生命值\r\n攻击对敌人造成 10% 最大生命值的溅射伤害"; } }
        public static string 狂徒铠甲 { get { return "狂徒铠甲\r\n+200生命值 +200生命值\r\n每秒恢复 6% 已损失生命值"; } }
        public static string 离子火花 { get { return "离子火花\r\n+20% 技能伤害 +20 魔法抗性\r\n每当敌人使用技能时，他们将受到 200 点真实伤害"; } }
        public static string 灵风 { get { return "灵风\r\n+200生命值 +20 魔法抗性\r\n战斗开始时，放逐一个敌人，持续 5 秒"; } }
        public static string 卢安娜的飓风 { get { return "卢安娜的飓风\r\n+40 魔法抗性\r\n普攻对一个额外目标造成 25% 伤害，可以附带攻击特效"; } }
        public static string 卢登的回声 { get { return "卢登的回声\r\n+20 法力值 +20% 技能伤害\r\n技能对命中目标造成 200 点溅射伤害"; } }
        public static string 灭世者的死亡之帽 { get { return "灭世者的死亡之帽\r\n+20% 技能伤害 +20% 技能伤害\r\n造成 50% 技能伤害"; } }
        public static string 莫雷洛秘典 { get { return "莫雷洛秘典\r\n+20% 技能伤害 +200 生命值\r\n技能灼烧敌人 15% 最大生命值伤害"; } }
        public static string 破败王者之刃 { get { return "破败王者之刃\r\n+40% 攻击速度\r\n携带者也是一名剑士"; } }
        public static string 骑士之誓 { get { return "骑士之誓\r\n+40 护甲\r\n携带者也是一名骑士"; } }
        public static string 神圣之剑 { get { return "神圣之剑\r\n+20 攻击力 +20% 攻击速度\r\n携带者每秒获得 5% 暴击几率"; } }
        public static string 朔极之矛 { get { return "朔极之矛\r\n+20 攻击力 +20 法力值\r\n在使用技能后，携带者每次攻击恢复自身 15% 最大法力值"; } }
        public static string 斯塔缇克电刃 { get { return "斯塔缇克电刃\r\n+20% 攻击速度 +20 法力值\r\n每第 3 次普通攻击造成 100 点溅射魔法伤害，总会命中 3 个额外的目标"; } }
        public static string 肃静 { get { return "肃静\r\n+20 法力值 +20 魔法抗性\r\n普通攻击有 50% 概率造成沉默效果"; } }
        public static string 无尽之刃 { get { return "无尽之刃\r\n+20 攻击力 +20 攻击力\r\n+150% 暴击伤害"; } }
        public static string 蜥蜴长老之赐 { get { return "蜥蜴长老之赐\r\n+20 护甲 +200 生命值\r\n普通攻击造成 2.5% 灼烧伤害"; } }
        public static string 饮血剑 { get { return "饮血剑\r\n+20 攻击力 +20 魔法抗性\r\n普通攻击附带 50% 吸血"; } }
        public static string 幽梦之灵 { get { return "幽梦之灵\r\n+40 攻击力\r\n携带者也是一名刺客"; } }
        public static string 悠米 { get { return "悠米\r\n+40% 技能伤害\r\n携带者也是一名法师"; } }
        public static string 折剑者 { get { return "折剑者\r\n+20 护甲 +20 魔法抗性\r\n普通攻击有 25% 概率造成缴械效果"; } }
        public static string 自然之力 { get { return "自然之力\r\n+1 人口"; } }
        public static string 诅咒之刃 { get { return "诅咒之刃\r\n+20% 攻击速度 +20 魔法抗性\r\n普通攻击有 20% 几率缩小敌人 1 星级"; } }

    }
}
