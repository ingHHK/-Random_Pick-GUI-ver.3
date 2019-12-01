using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DisaplyWords : Form
    {
        Random random = new Random();
        int[] checked_Category = new int[4];
        int[] selected_Category = new int[4];
        int[] answer_Number = new int[40];
        int[] selected_Number = new int[40];
        int flag = 0, picking_Number, j = 0, picking_word;
        float font_size;

        public DisaplyWords(ref int[] checked_Category, int number, float font_size)
        {
            InitializeComponent();
            this.checked_Category = checked_Category;
            picking_Number = number;
            this.font_size = font_size;
        }
        
        public class Data
        {
            public string[,] words = new string[4, 77] { { "블루베리",
        "딸기",
        "망고",
        "키위",
        "레몬",
        "개여주",
        "귤",
        "구스베리",
        "대추",
        "다래",
        "배",
        "라임",
        "리치",
        "망고스틴",
        "매실",
        "머스크멜론",
        "모과",
        "오렌지",
        "비파",
        "살구",
        "산수유",
        "아보카도",
        "바나나",
        "양매",
        "유자",
        "어름",
        "코코넛",
        "포도",
        "크렌베리",
        "토마토",
        "탠저린오렌지",
        "하미과",
        "앵두",
        "참외",
        "밤",
        "낑깡",
        "버찌",
        "파인애플",
        "패션푸르트",
        "망가",
        "메론",
        "망기스",
        "복숭아",
        "감",
        "한라봉",
        "거봉",
        "구아바",
        "대추야자",
        "두리안",
        "라임오렌지",
        "람부딴",
        "라즈베리",
        "랑카",
        "롱안",
        "리즈",
        "무화과",
        "천도복숭아",
        "사과",
        "산딸기",
        "석류",
        "수박",
        "슈가애플",
        "아오리",
        "애플망고",
        "야자",
        "연시",
        "오디",
        "용안",
        "자두",
        "자몽",
        "체리",
        "치코",
        "탱자",
        "파파야",
        "파파야멜론",
        "홍로",
        "홍월"
        },
		/*b*/{ "호랑이",
        "하이에나",
        "말",
        "치타",
        "늑대",
        "여우",
        "사막여우",
        "북극여우",
        "지네",
        "사마귀",
        "바다악어",
        "인도악어",
        "나일악어",
        "백상아리",
        "흡혈박쥐",
        "미시시피앨리게이터",
        "인도가비알",
        "코요테",
        "까마귀",
        "검독수리",
        "흰머리수리",
        "물수리",
        "매",
        "참매",
        "청상아리",
        "왕독수리",
        "칡부엉이",
        "붉은솔개",
        "민물가마우지",
        "물총새",
        "설표",
        "흰담비",
        "수달",
        "해달",
        "불곰",
        "범고래",
        "백곰",
        "리카온",
        "갈기늑대",
        "바다사자",
        "얼룩무늬바다표범",
        "처진귀대머리수리",
        "코모도왕도마뱀",
        "아나콘다",
        "코브라",
        "방울뱀",
        "사자",
        "비단구렁이",
        "코끼리",
        "자이언트판다",
        "하마",
        "코뿔소",
        "캥거루",
        "왈라비",
        "맷돼지",
        "까치",
        "닭",
        "표범",
        "토끼",
        "다람쥐",
        "주걱사슴",
        "산사향노루",
        "유럽물소",
        "늪쥐",
        "청설모",
        "랫서판다",
        "침팬지",
        "오랑우탄",
        "치타",
        "고릴라",
        "강아지",
        "고양이",
        "양",
        "다람쥐",
        "사자",
        "호랑이",
        "염소"
        },
		/*c*/{ "가봉",
        "몽골",
        "라오스",
        "라이베리아",
        "미얀마",
        "그리스",
        "방글라데시",
        "벨리즈",
        "보스니아",
        "불가리아",
        "바누아투",
        "베트남",
        "사모아",
        "덴마크",
        "세네갈",
        "싱가폴",
        "소말리아",
        "기니비사우",
        "스위스",
        "알바니아",
        "앤티가바부다",
        "오스트리아",
        "엘살바도르",
        "에스토니아",
        "대한민국",
        "아이슬란드",
        "이라크",
        "일본",
        "우크라이나",
        "네팔",
        "중앙아프리카공화국",
        "자메이카",
        "칠레",
        "캐나다",
        "콩고 공화국",
        "레바논",
        "코트디부아르",
        "콩고민주공화국",
        "쿠웨이트",
        "타지키스탄",
        "튀니지",
        "니게르",
        "핀란드",
        "파나마",
        "필리핀",
        "리히텐슈타인",
        "가나",
        "기니",
        "나우루",
        "니카라과",
        "남아프리카공화국",
        "독일",
        "라트비아",
        "리비아",
        "루마니아",
        "말라위",
        "러시아연방",
        "말타",
        "멕시코",
        "몬테네그로",
        "몰도바 공화국",
        "바레인",
        "벨기에",
        "볼리비아",
        "브루나이",
        "북한",
        "세인트키츠네비스",
        "마다가스카르",
        "산마리노",
        "세르비아",
        "슬로바키아",
        "스페인",
        "스와질랜드",
        "아프가니스탄",
        "앙골라",
        "오스트레일리아",
        "헝가리"
        },
		/*d*/{ "얼음빙수",
        "크림스파게티",
        "치킨",
        "햄버거",
        "소세지",
        "크로아상",
        "양념감자",
        "마카롱",
        "컵케익",
        "생크림",
        "초콜릿케익",
        "짜짱면",
        "피자",
        "김치",
        "오이소박이",
        "된장국",
        "떡볶이",
        "순대",
        "새우튀김",
        "짬뽕",
        "우동",
        "냉면",
        "달팽이구이",
        "팟타이",
        "냉우동",
        "배추전",
        "파전",
        "쿠키",
        "삼각김밥",
        "컵라면",
        "커피",
        "도넛",
        "삼겹살",
        "돼지갈비",
        "똠양꿍",
        "수프",
        "우유",
        "오삼불고기",
        "샤브샤브",
        "소프트아이스크림",
        "샤오롱빠오",
        "호두과자",
        "오징어숯불구이",
        "닭갈비",
        "닭꼬치",
        "랍스타",
        "완자",
        "퐁듀",
        "어묵",
        "김밥",
        "뿌팟퐁커리",
        "카우팟",
        "회",
        "유부초밥",
        "땅콩샌드",
        "오리고기",
        "김치찌개",
        "수박",
        "초콜릿",
        "청국장",
        "도토리묵",
        "순두부",
        "사탕",
        "토마토스파게티",
        "아이스크림케이크",
        "샤베트",
        "치즈",
        "바게트",
        "치즈스틱",
        "푸딩",
        "칼국수",
        "만두",
        "찜빵",
        "팥빵",
        "갈치찜",
        "고등어구이",
        "순대국밥"
        }
    };
        }

        private void repick_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Displaying_Words();
        }

        private void answer_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < picking_Number; i++)
            {
                switch (answer_Number[i])
                {
                    case 0:
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.SelectedText = "과일 - (빨강)\n";
                        break;
                    case 1:
                        richTextBox1.SelectionColor = Color.Blue;
                        richTextBox1.SelectedText = "동물 - (파랑)\n";
                        break;
                    case 2:
                        richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.SelectedText = "국가 - (초록)\n";
                        break;
                    case 3:
                        richTextBox1.SelectionColor = Color.Black;
                        richTextBox1.SelectedText = "음식 - (검정)\n";
                        break;
                }
            }
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, font_size, newFontStyle);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void select_Number(ref int[] selected_Number)
        {
            for (int i = 0; i < picking_Number; i++)
            {
                flag = 0;
                while (flag != 1)
                {
                    selected_Number[i] = random.Next(0, 77);
                    for (int k = 0; k < picking_Number; k++)
                    {
                        if (k == picking_Number - 1 || (k == picking_Number-1 && i == picking_Number-1))
                            flag = 1;
                        else if (i == k)
                            continue;
                        else if (selected_Number[i] == selected_Number[k])
                            break;
                    }
                }
            }
        }

        public void select_Category()
        {
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                if (checked_Category[i] != 0)
                {
                    selected_Category[j] = checked_Category[i] - 1;
                    j++;
                }
            }
        }

        public void Displaying_Words()
        {
            Data data = new Data();
            select_Category();
            select_Number(ref selected_Number);
            for(int i = 0; i < picking_Number; i++)
            {
                picking_word = random.Next(0, j);
                answer_Number[i] = selected_Category[picking_word];
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.AppendText(data.words[selected_Category[picking_word],selected_Number[i]] + Environment.NewLine);
            }
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, font_size, newFontStyle);
        }

    }
}
