using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LOL_TFT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            暴风大剑_背景.Source = 图片.暴风大剑;
            反曲之弓_背景.Source = 图片.反曲之弓;
            无用大棒_背景.Source = 图片.无用大棒;
            女神之泪_背景.Source = 图片.女神之泪;
            巨人腰带_背景.Source = 图片.巨人腰带;
            锁子甲_背景.Source = 图片.锁子甲;
            负极斗篷_背景.Source = 图片.负极斗篷;
            金铲铲_背景.Source = 图片.金铲铲;

            暴风大剑.ToolTip = new ToolTip { Content = 装备.暴风大剑 };
            反曲之弓.ToolTip = new ToolTip { Content = 装备.反曲之弓 };
            无用大棒.ToolTip = new ToolTip { Content = 装备.无用大棒 };
            女神之泪.ToolTip = new ToolTip { Content = 装备.女神之泪 };
            巨人腰带.ToolTip = new ToolTip { Content = 装备.巨人腰带 };
            锁子甲.ToolTip = new ToolTip { Content = 装备.锁子甲 };
            负极斗篷.ToolTip = new ToolTip { Content = 装备.负极斗篷 };
            金铲铲.ToolTip = new ToolTip { Content = 装备.金铲铲 };

            修改结果(暴风大剑_2, 图片.暴风大剑, 装备.暴风大剑);
            修改结果(反曲之弓_2, 图片.反曲之弓, 装备.反曲之弓);
            修改结果(无用大棒_2, 图片.无用大棒, 装备.无用大棒);
            修改结果(女神之泪_2, 图片.女神之泪, 装备.女神之泪);
            修改结果(巨人腰带_2, 图片.巨人腰带, 装备.巨人腰带);
            修改结果(锁子甲_2, 图片.锁子甲, 装备.锁子甲);
            修改结果(负极斗篷_2, 图片.负极斗篷, 装备.负极斗篷);
            修改结果(金铲铲_2, 图片.金铲铲, 装备.金铲铲);
        }

        private void 修改结果(Image 结果, BitmapImage 图片数据, string 装备说明)
        {
            结果.Source = 图片数据;
            结果.ToolTip = new ToolTip { Content = 装备说明 };
        }

        private void 调节图片亮度(string 元素)
        {
            暴风大剑_背景.Opacity = 0.2;
            反曲之弓_背景.Opacity = 0.2;
            无用大棒_背景.Opacity = 0.2;
            女神之泪_背景.Opacity = 0.2;
            巨人腰带_背景.Opacity = 0.2;
            锁子甲_背景.Opacity = 0.2;
            负极斗篷_背景.Opacity = 0.2;
            金铲铲_背景.Opacity = 0.2;
            switch (元素)
            {
                case "暴风大剑":
                    暴风大剑_背景.Opacity = 1;
                    break;
                case "反曲之弓":
                    反曲之弓_背景.Opacity = 1;
                    break;
                case "无用大棒":
                    无用大棒_背景.Opacity = 1;
                    break;
                case "女神之泪":
                    女神之泪_背景.Opacity = 1;
                    break;
                case "巨人腰带":
                    巨人腰带_背景.Opacity = 1;
                    break;
                case "锁子甲":
                    锁子甲_背景.Opacity = 1;
                    break;
                case "负极斗篷":
                    负极斗篷_背景.Opacity = 1;
                    break;
                case "金铲铲":
                    金铲铲_背景.Opacity = 1;
                    break;

            }
        }

        private void 暴风大剑_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("暴风大剑");
            修改结果(结果_1, 图片.无尽之刃, 装备.无尽之刃);
            修改结果(结果_2, 图片.神圣之剑, 装备.神圣之剑);
            修改结果(结果_3, 图片.海克斯科技枪刃, 装备.海克斯科技枪刃);
            修改结果(结果_4, 图片.朔极之矛, 装备.朔极之矛);
            修改结果(结果_5, 图片.基克的先驱, 装备.基克的先驱);
            修改结果(结果_6, 图片.守护天使, 装备.守护天使);
            修改结果(结果_7, 图片.饮血剑, 装备.饮血剑);
            修改结果(结果_8, 图片.幽梦之灵, 装备.幽梦之灵);
        }

        private void 反曲之弓_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("反曲之弓");
            修改结果(结果_1, 图片.神圣之剑, 装备.神圣之剑);
            修改结果(结果_2, 图片.疾射火炮, 装备.疾射火炮);
            修改结果(结果_3, 图片.鬼索的狂暴之刃, 装备.鬼索的狂暴之刃);
            修改结果(结果_4, 图片.斯塔缇克电刃, 装备.斯塔缇克电刃);
            修改结果(结果_5, 图片.巨型九头蛇, 装备.巨型九头蛇);
            修改结果(结果_6, 图片.幻影之舞, 装备.幻影之舞);
            修改结果(结果_7, 图片.诅咒之刃, 装备.诅咒之刃);
            修改结果(结果_8, 图片.破败王者之刃, 装备.破败王者之刃);
        }

        private void 无用大棒_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("无用大棒");
            修改结果(结果_1, 图片.海克斯科技枪刃, 装备.海克斯科技枪刃);
            修改结果(结果_2, 图片.鬼索的狂暴之刃, 装备.鬼索的狂暴之刃);
            修改结果(结果_3, 图片.灭世者的死亡之帽, 装备.灭世者的死亡之帽);
            修改结果(结果_4, 图片.卢登的回声, 装备.卢登的回声);
            修改结果(结果_5, 图片.莫雷洛秘典, 装备.莫雷洛秘典);
            修改结果(结果_6, 图片.钢铁烈阳之匣, 装备.钢铁烈阳之匣);
            修改结果(结果_7, 图片.离子火花, 装备.离子火花);
            修改结果(结果_8, 图片.悠米, 装备.悠米);
        }

        private void 女神之泪_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("女神之泪");
            修改结果(结果_1, 图片.朔极之矛, 装备.朔极之矛);
            修改结果(结果_2, 图片.斯塔缇克电刃, 装备.斯塔缇克电刃);
            修改结果(结果_3, 图片.卢登的回声, 装备.卢登的回声);
            修改结果(结果_4, 图片.炽天使之拥, 装备.炽天使之拥);
            修改结果(结果_5, 图片.救赎, 装备.救赎);
            修改结果(结果_6, 图片.冰霜之心, 装备.冰霜之心);
            修改结果(结果_7, 图片.肃静, 装备.肃静);
            修改结果(结果_8, 图片.暗裔, 装备.暗裔);
        }

        private void 巨人腰带_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("巨人腰带");
            修改结果(结果_1, 图片.基克的先驱, 装备.基克的先驱);
            修改结果(结果_2, 图片.巨型九头蛇, 装备.巨型九头蛇);
            修改结果(结果_3, 图片.莫雷洛秘典, 装备.莫雷洛秘典);
            修改结果(结果_4, 图片.救赎, 装备.救赎);
            修改结果(结果_5, 图片.狂徒铠甲, 装备.狂徒铠甲);
            修改结果(结果_6, 图片.蜥蜴长老之赐, 装备.蜥蜴长老之赐);
            修改结果(结果_7, 图片.灵风, 装备.灵风);
            修改结果(结果_8, 图片.冰霜之锤, 装备.冰霜之锤);
        }

        private void 锁子甲_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("锁子甲");
            修改结果(结果_1, 图片.守护天使, 装备.守护天使);
            修改结果(结果_2, 图片.幻影之舞, 装备.幻影之舞);
            修改结果(结果_3, 图片.钢铁烈阳之匣, 装备.钢铁烈阳之匣);
            修改结果(结果_4, 图片.冰霜之心, 装备.冰霜之心);
            修改结果(结果_5, 图片.蜥蜴长老之赐, 装备.蜥蜴长老之赐);
            修改结果(结果_6, 图片.荆棘之甲, 装备.荆棘之甲);
            修改结果(结果_7, 图片.折剑者, 装备.折剑者);
            修改结果(结果_8, 图片.骑士之誓, 装备.骑士之誓);
        }

        private void 负极斗篷_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("负极斗篷");
            修改结果(结果_1, 图片.饮血剑, 装备.饮血剑);
            修改结果(结果_2, 图片.诅咒之刃, 装备.诅咒之刃);
            修改结果(结果_3, 图片.离子火花, 装备.离子火花);
            修改结果(结果_4, 图片.肃静, 装备.肃静);
            修改结果(结果_5, 图片.灵风, 装备.灵风);
            修改结果(结果_6, 图片.折剑者, 装备.折剑者);
            修改结果(结果_7, 图片.巨龙之爪, 装备.巨龙之爪);
            修改结果(结果_8, 图片.卢安娜的飓风, 装备.卢安娜的飓风);
        }

        private void 金铲铲_Click(object sender, RoutedEventArgs e)
        {
            调节图片亮度("金铲铲");
            修改结果(结果_1, 图片.幽梦之灵, 装备.幽梦之灵);
            修改结果(结果_2, 图片.破败王者之刃, 装备.破败王者之刃);
            修改结果(结果_3, 图片.悠米, 装备.悠米);
            修改结果(结果_4, 图片.暗裔, 装备.暗裔);
            修改结果(结果_5, 图片.冰霜之锤, 装备.冰霜之锤);
            修改结果(结果_6, 图片.骑士之誓, 装备.骑士之誓);
            修改结果(结果_7, 图片.卢安娜的飓风, 装备.卢安娜的飓风);
            修改结果(结果_8, 图片.自然之力, 装备.自然之力);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void 退出按钮_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void 帮助按钮_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("点击第一行的装备图标，第三行将会展示所点击装备与第二行装备分别合成后的结果\r\n\r\n鼠标移动到装备上方会显示装备说明", "帮助", MessageBoxButton.OK);
        }

        private void 关于按钮_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Copyright (C) 2019\r\nDESMG All Rights Reserved.\r\nLicense: GNU GPL V3\r\n", "关于", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
