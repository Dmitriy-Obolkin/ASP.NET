using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int count;
    int max=10;
    int res;

    Voprosu[] v1;

    class Voprosu
    {
        private string cu;
        public string Cu
        {
            get { return cu; }
            set { cu = value; }
        }

        private string vopros;
        public string Vopros
        {
            get { return vopros; }
            set { vopros = value; }
        }

        public string otvet1;

        public string Otvet1
        {
            get { return otvet1; }
            set { otvet1 = value; }
        }

        public string otvet2;

        public string Otvet2
        {
            get { return otvet2; }
            set { otvet2 = value; }
        }

        public string otvet3;

        public string Otvet3
        {
            get { return otvet3; }
            set { otvet3 = value; }
        }

        public string otvet4;

        public string Otvet4
        {
            get { return otvet4; }
            set { otvet4 = value; }
        }
        private string res;

        public string Res
        {
            get { return res; }
            set { res = value; }
        }
        public Voprosu(string cu, string _vopros, string a, string b, string c, string d, string r)
        {
            this.cu = cu;
            this.vopros = _vopros;
            this.otvet1 = a;
            this.otvet2 = b;
            this.otvet3 = c;
            this.otvet4 = d;
            this.res = r;
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        
        Voprosu[] v = {new Voprosu("Вопрос 1", "Что такое ASP NET?", "a) платформа разработки игр", "b) язык программирования", "c) платформа разработки веб-приложений", "d) компилятор", "с"),
            new Voprosu("Вопрос 2", "Какой язык программирования, в большинстве случаев, использует ASP NET?", "a) C#", "b) C", "c) HTML", "d) PHP", "a"),
            new Voprosu("Вопрос 3", "К преимуществам Web Forms относят", "a) возможность локалькой работы", "b) простота", "c) хранение состояния между обращениями на сервер  ", "d) сплошная модель серверных элементов управления", "c"),
            new Voprosu("Вопрос 4", "При создании БД первичным ключом таблицы Task является", "a) TaskID", "b) Title", "c) Text", "d) CreatedOn", "a"),
            new Voprosu("Вопрос 5", "Абстракции для упрощения разработки веб-приложений делятся на", "a) объектные", "b) компонентные", "c) гибкие", "d) сложные", "c"),
            new Voprosu("Вопрос 6", "В проекте ASP NET Framework - Global.asax является", "a) представлением", "b) моделью", "c) контроллером", "d) таблицей маршрутизации", "d"),
            new Voprosu("Вопрос 7", "К какому типу абстракций относится ASP.NЕТ?", "a) простому", "b) сложному", "c) гибкому", "d) смешанному", "b"),
            new Voprosu("Вопрос 8", "Таблица статусов включает в себя", "a) Text", "b) Enabled", "c) AssignetOn", "d) StateId", "d"),
            new Voprosu("Вопрос 9", "ASP.NET Framework базируется на", "a) .aspx-файлах", "b) .aspw-файлах", "c) .html-файлах", "d) .web-файлах", "a"),
            new Voprosu("Вопрос 10", "К какому типу абстракций относятся классические ASP", "a) стандартному", "b) гибкому", "c) сложному", "d) простому", "d"),
            };

        v1 = v;
        Label3.Text = v[count].Cu;
        Label1.Text = v[count].Vopros;
        RadioButton1.Text = v[count].Otvet1;
        RadioButton2.Text = v[count].Otvet2;
        RadioButton3.Text = v[count].Otvet3;
        RadioButton4.Text = v[count].Otvet4;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        count = Convert.ToInt32(Button2.Text);
        if (count < max)
            {
                if (RadioButton1.Checked == true)
                {
                    if (v1[count].Res == "a")
                    {
                        res = Convert.ToInt32(Button3.Text);
                        res++;
                        Button3.Text = Convert.ToString(res);
                    }
                }
                if (RadioButton2.Checked == true)
                {
                    if (v1[count].Res == "b")
                    {
                    res = Convert.ToInt32(Button3.Text);
                    res++;
                    Button3.Text = Convert.ToString(res);
                }
                }
                if (RadioButton3.Checked == true)
                {
                    if (v1[count].Res == "c")
                    {
                    res = Convert.ToInt32(Button3.Text);
                    res++;
                    Button3.Text = Convert.ToString(res);
                }
                }
                if (RadioButton4.Checked == true)
                {
                    if (v1[count].Res == "d")
                    {
                    res = Convert.ToInt32(Button3.Text);
                    res++;
                    Button3.Text = Convert.ToString(res);
                }
                }
                count++;
                Button2.Text = Convert.ToString(count);
                if (count < max)
                {
                    Label3.Text = v1[count].Cu;
                    Label1.Text = v1[count].Vopros;
                    RadioButton1.Text = v1[count].Otvet1;
                    RadioButton2.Text = v1[count].Otvet2;
                    RadioButton3.Text = v1[count].Otvet3;
                    RadioButton4.Text = v1[count].Otvet4;
                }
                else
                {
                    Button1.Enabled = false;
                Label3.Text = "Результат!";
                res = Convert.ToInt32(Button3.Text);
                Label1.Text = "Количество правильных ответов: " + Convert.ToString(res) + "/10";
                RadioButton1.Text = "";
                RadioButton2.Text = "";
                RadioButton3.Text = "";
                RadioButton4.Text = "";
            }
            
        }
    }


}
