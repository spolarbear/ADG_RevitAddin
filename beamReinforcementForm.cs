using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Autodesk.Revit;
using Autodesk.Revit.DB;

using System.Text.RegularExpressions;

using Warrentech.Velo.BimDataModel;
using System.Threading;
using DataAccess.Structural.Pkpm;
using DataAccess.Structural.Pkpm.Converter;
using DataAccess.Structural.Pkpm.Models;


namespace ADG.ADG_RevitAddin.CS
{
    public partial class beamReinforcementForm : System.Windows.Forms.Form
    {
        public Element bl = null;
        public beamReinforcementForm()
        {
            InitializeComponent();
        }
        public beamReinforcementForm(Element bl)
        {
            this.bl = bl;
            InitializeComponent();
        }
        public string s(int ds,int num){
            return (3.14159*Math.Pow(ds/2,2)*num/100).ToString("F1");
        }
        public string s(string ds1, string num1)
        {
            int ds = Convert.ToInt32(ds1);
            int num = Convert.ToInt32(num1);
            return (3.14159*Math.Pow(ds/2,2)*num/100).ToString("F1");
        }
        public string s(string st)
        {
            double sTotal = 0;
            string[] sArray = st.Split(new char[2] { '+', '/'});
            foreach (string eachString in sArray)
            {
                string[] pj = eachString.Split(new char[5] {'#','&','%','$' ,' '});
                sTotal += Convert.ToDouble(s(pj[1], pj[0]));   
            }
            return sTotal.ToString("F2");
        }

        private void beamReinforcementForm_Load(object sender, EventArgs e)
        {
            FamilyInstance beam = bl as FamilyInstance;
            if (beam.ParametersMap.Contains("ST-Beam-梁编号"))
            {
                label1.Text = beam.get_Parameter("ST-Beam-梁编号").AsString() + " " + beam.Symbol.Name;
            }
            if(beam.ParametersMap.Contains("ST-Beam-箍筋行"))
                label2.Text = beam.get_Parameter("ST-Beam-箍筋行").AsString().Replace("&", "&&");
            if (beam.ParametersMap.Contains("ST-Beam-上部筋"))
            {
                label3.Text = beam.get_Parameter("ST-Beam-上部筋").AsString().Replace("&", "&&");
                textBox3.Text = beam.get_Parameter("ST-Beam-上部筋").AsString();
            }
            if (beam.ParametersMap.Contains("ST-Beam-腰筋"))
            {
                label4.Text = beam.get_Parameter("ST-Beam-腰筋").AsString().Replace("&", "&&");
                textBox4.Text = beam.get_Parameter("ST-Beam-腰筋").AsString();
            }
            if (beam.ParametersMap.Contains("ST-Beam-标高"))
            {
                label6.Text = beam.get_Parameter("ST-Beam-标高").AsString();
                textBox5.Text = beam.get_Parameter("ST-Beam-标高").AsString();
            }
            

            asd1.Text = "["+beam.get_Parameter("ST-Beam-GJ-Asd1").AsValueString()+"]";
            asd2.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asd2").AsValueString() + "]";
            asd3.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asd3").AsValueString() + "]";
            asu1.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asu1").AsValueString() + "]";
            asu2.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asu2").AsValueString() + "]";
            asu3.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asu3").AsValueString() + "]";
            asv.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asv").AsValueString() + "]";
            asv0.Text = "[" + beam.get_Parameter("ST-Beam-GJ-Asv0").AsValueString() + "]";

            pj1.Text = beam.get_Parameter("ST-Beam-跨中底筋").AsString().Replace("&", " ");
            if (Convert.ToDouble(s(pj1.Text)) > Convert.ToDouble(beam.get_Parameter("ST-Beam-GJ-Asd2").AsValueString()))
                asd2.ForeColor = System.Drawing.Color.ForestGreen;
            else 
                asd2.ForeColor = System.Drawing.Color.Red;
            asd2.Text =  s(pj1.Text) + asd2.Text;


            pj2.Text = beam.get_Parameter("ST-Beam-起点面筋").AsString().Replace("&", " ");
            asu1.Text = s(pj2.Text) + asu1.Text ;
            pj3.Text = beam.get_Parameter("ST-Beam-终点面筋").AsString().Replace("&", " ");
            asu3.Text = s(pj3.Text) + asu3.Text;


            string kujing = beam.get_Parameter("ST-Beam-箍筋行").AsString();
            Regex Pattern = new Regex(@"^[$#&%](\d+)@(\d+)[/]?(\d+)?\((\d)\)");
            var result = Pattern.Match(kujing).Groups;
            //comboBox1.Text = "2";
            string asv_d, asv_jj1, asv_jj2, asv_num;
            if (result[4].Length > 0)
            {
                asv_d = result[1].ToString();
                asv_jj1 = result[2].ToString();
                asv_jj2 = result[3].ToString();
                asv_num = result[4].ToString();
            }else{
                asv_d = result[1].ToString();
                asv_jj1 = result[2].ToString();
                asv_jj2 = asv_jj1;
                asv_num = result[3].ToString();
            }

            comboBox1.Text = asv_d;
            comboBox3.Text = asv_jj1;
            comboBox4.Text = asv_jj2;
            comboBox5.Text = asv_num;

            int ds = Convert.ToInt32(asv_d);
            int d = Convert.ToInt32(asv_jj1);
            int num = Convert.ToInt32(asv_num);

            asv.Text =
                (3.14159 * Math.Pow(ds / 2, 2) / d * 100 * num / 100).ToString("F2")
                 + asv.Text;
            d = Convert.ToInt32(asv_jj2);
            asv0.Text =
                (3.14159 * Math.Pow(ds / 2, 2) / d * 100 * num / 100).ToString("F2")
                 + asv0.Text;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //创建画板,这里的画板是由Form提供的.
            Pen p = new Pen(System.Drawing.Color.Gray, 1);//定义了一个色,宽度为2的画笔
            //g.DrawLine(p, 10, 10, 100, 100);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
            g.DrawRectangle(p, 2, 2, 216, 16);//在画板上画矩形,起始坐标为(10,10),宽为,高为
            p = new Pen(System.Drawing.Color.Red, 2);
            g.DrawLine(p, 2, 5, 218, 5);
            g.DrawLine(p, 2, 16, 218, 16);

        }
    }
}
