using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "CreateTime", "IsDel", "State", "TypeName", "UpdateTime" },
                values: new object[] { 1, new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3528), false, true, "国语书籍", new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "CreateTime", "IsDel", "State", "TypeName", "UpdateTime" },
                values: new object[] { 2, new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3540), false, true, "外语书籍", new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.InsertData(
                table: "BookInfos",
                columns: new[] { "Id", "Author", "BookTypeID", "Content", "CreateTime", "Description", "IsDel", "Name", "Price", "State", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "鲁迅", 1, "...", new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3546), "鲁迅的百草集", false, "百草集", 66.3m, true, new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3547) },
                    { 2, "鲁迅", 1, "祥林嫂是一个受尽封建礼教压榨的穷苦农家妇女。丈夫死后，狠心的婆婆要将她出卖。她被逼出逃，到鲁镇鲁四老爷家做佣工，受尽鄙视、虐待。很快她又被婆婆家抢走，并且拿走了她在鲁四老爷家打工的所有工钱，然后卖到贺家成亲。贺老六是个纯朴忠厚的农民，很快又有了儿子阿毛，祥林嫂终于过上了安稳日子。然而命运多舛，贺老六因伤寒病复发而死，不久，阿毛又被狼吃掉。经受双重打击的祥林嫂，丧魂落魄，犹如行尸走肉，于是，走投无路的她只能去再次投奔到鲁四老爷家。可是人们还说她改嫁“有罪”，要她捐门槛“赎罪”，不然到了“阴间”还要受苦。她千辛万苦积钱捐了门槛后，依然摆脱不了人们的歧视。最后，她沿街乞讨，在鲁镇一年一度的“祝福”的鞭炮声中，惨死在街头。但是，人们非但没有可怜她，还都骂她是一个谬种。", new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3549), "彷徨一般的人生", false, "彷徨", 76.8m, true, new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3550) },
                    { 3, "余华", 1, "福贵出身于地主家庭，年轻时是个浪荡公子，经常去城里的一家妓院吃喝嫖赌。他丈人在城里开了一家米行，福贵每次去妓院后都让一个妓女背着他上街，然后从丈人的米行经过，其品行之放荡堕落可见一斑。后来，福贵中了别人的圈套，把家里的田地、房产都输了个精光，于是全家一夜之间从大地主沦为了穷人。福贵的父亲郁闷而亡。父亲的亡故使福贵也清醒过来，决定重新做人。从此，福贵租地度日，他穿上粗布衣服，拿起农具，开始了他一生的农民生涯。不久，福贵的母亲生病了，他拿了家里仅剩的两块银圆，去城里请医生。但他在城里发生了意外：他被国民党军队抓了壮丁。\r\n两年后，福贵被解放军俘虏并释放了。福贵回到家里后，知道母亲早已故去，女儿凤霞也在一次高烧后成了哑巴。福贵后来又经历了新中国成立后的土地改革、人民公社、大炼钢铁、三年饥荒、“文化大革命”等时期。在此期间，福贵和亲人生离死别：为了让儿子有庆上学，他把女儿送给了别人，不久，女儿跑了回来，全家重又团圆；县长的老婆生孩子需要输血，有庆被一个不负责任的大夫抽血过量致死，而那县长竟是福贵在国民党军队时的小战友春生。春生在后来的“文革”中经不住迫害，悬梁自尽。\r\n几年后，福贵的女儿凤霞嫁了人，但却在产后大出血中死去。有庆、凤霞死后，福贵的妻子家珍也撒手人寰，剩下的只有福贵和女婿二喜、外孙苦根。祖孙三代相依为命了几年后，二喜在一次事故中惨死。福贵和外孙苦根同住几年后，苦根也在一次意外中失去了幼小的生命。最后，福贵买了一头要被宰杀的老水牛，并给它取了“福贵”之名，艰难而平静地活着余生。", new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3551), "什么是活着，余华成名作", false, "活着", 36.9m, true, new DateTime(2024, 1, 11, 17, 16, 16, 526, DateTimeKind.Local).AddTicks(3552) },
                    { 4, "海明威", 2, "《老人与海》故事的背景是在20世纪中叶的古巴。主人公是一位名叫圣地亚哥的老渔夫，配角是一个叫马诺林的小孩。风烛残年的老渔夫一连八十四天都没有钓到一条鱼，但他仍不肯认输，而是充满着奋斗的精神，终于在第八十五天钓到一条身长十八尺，体重一千五百磅的大马林鱼。大鱼拖着船往海里走，老人依然死拉着不放，即使没有水，没有食物，没有武器，没有助手，左手抽筋，他也丝毫不灰心。经过两天两夜之后，他终于杀死大鱼，把它拴在船边。但许多鲨鱼立刻前来抢夺他的战利品。他一一地杀死它们，到最后只剩下一支折断的舵柄作为武器。结果，大鱼仍难逃被吃光的命运，最终，老人筋疲力尽地拖回一副鱼骨头。他回到家躺在床上，只好从梦中去寻回那往日美好的岁月，以忘却残酷的现实。", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "国外著名的书籍", false, "老人与海", 88.3m, true, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
