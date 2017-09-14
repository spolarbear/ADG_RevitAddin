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

using Warrentech.Velo.BimDataModel;
using System.Threading;
using DataAccess.Structural.Pkpm;
using DataAccess.Structural.Pkpm.Converter;
using DataAccess.Structural.Pkpm.Models;


namespace ADG.ADG_RevitAddin.CS
{
    public partial class beamForm : System.Windows.Forms.Form
    {
        public IList<Element> levelList;
        public BimBuilding building;
        public string temp = "";
        public BimProject bimProject = new BimProject();
        public string filepath = @"D:\杨新\pktest\";
        public string fileName = "1.JWS";
        public StoreyNumber storeyNum = new StoreyNumber(1);//1~N
        public double pkpmResetX, pkpmResetY;
        public int levelSet;
        public bool ifguibing;
        Thread thread=null;
        public beamForm()
        {
            InitializeComponent();
        }

        public beamForm(IList<Element> levelList)
        {
            this.levelList = levelList;
            //this.building = building;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshStorey();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void beamForm_Load(object sender, EventArgs e)
        {
            //pkpmImport pkpmData = new pkpmImport();
            int i = 1;
            //pkpmData.getPkpmFile();
            foreach (Element el in levelList)
            {
                int index = dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = el.Name;
                this.dataGridView1.Rows[index].Cells[1].Value = i.ToString();
                i++;
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //if (thread.IsAlive) { 
            //Thread.CurrentThread.Abort();
            //Thread.CurrentThread.Join();
            
            //thread.Join();
            this.temp = "fail";
        }
        protected void threadGetFile()
        {
            bimProject = new BimProject();   
            button3.Enabled = false;




            progressBar1.Value = 10;
            button3.Text = "创建工程路径";
            /* */
            PkpmHelper.PkpmWorkingDirectory = new DirectoryInfo(filepath);
            PkpmHelper.JwsFileName = filepath + fileName;///保利横琴-飞哥新
            /* */


            progressBar1.Value = 20;
            button3.Text = "创建BIM模型";
            /* */PKPMGeometryInfoLoader pkpmLoader = new PKPMGeometryInfoLoader(bimProject);




            progressBar1.Value = 30;
            button3.Text = "获取PKPM物理模型";
            /* */pkpmLoader.LoadGeometryInfo();



            progressBar1.Value = 50;
            button3.Text = "输出物理信息";
            this.label3.Text = this.bimProject.Buildings[0].Storeys.Count.ToString();


            progressBar1.Value = 60;
            button3.Text = "获取PKPM计算结果";
            /* */
            PKPMReinforcementLoader pkpmReinLoader = new PKPMReinforcementLoader(bimProject);
            StringBuilder readBinaryMessage = new StringBuilder();
            StringBuilder loadReinMessage = new StringBuilder();
            pkpmReinLoader.LoadReinforcement(readBinaryMessage, loadReinMessage);
            button3.Text = loadReinMessage.ToString();
            /* */

            progressBar1.Value = 100;
            //button3.Text = "重新读入PKPM数据";
            button3.Enabled = true;
            progressBar1.Visible = false;
            this.temp = "ok";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Value = 10;
            progressBar1.Step = 5;
            thread = new Thread(new ThreadStart(threadGetFile));
            thread.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\杨新\横琴保利\PKPM\保利横琴弹性0822弹性超限模型\";
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            //openFileDialog.DefaultExt = "jws";  
            openFileDialog.Filter = "JWS 文件 (.JWS)|*.JWS";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName.Replace(openFileDialog.SafeFileName, "");
                fileName = openFileDialog.SafeFileName;

                label4.Text = filepath;
                label5.Text = fileName;

                //button4.Text = openFileDialog.FileName;
            }
        }

        private void beamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread!=null) thread.Abort();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            this.ifguibing = checkBox4.Checked;
            storeyNum = new StoreyNumber(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));//1~N
            this.pkpmResetX = Convert.ToDouble(this.textBox1.Text);
            this.pkpmResetY = Convert.ToDouble(this.textBox2.Text);
            levelSet = dataGridView1.SelectedRows[0].Index;

            //label7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void refreshStorey()
        {
            if (bimProject.Buildings.Count == 0) return;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                StoreyNumber currentStoreyNum = new StoreyNumber(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                if (currentStoreyNum.Number > 0 && currentStoreyNum.Number <= bimProject.Buildings[0].Storeys.Count)
                    dataGridView1.Rows[i].Cells[2].Value = bimProject.Buildings[0].Storeys[currentStoreyNum].GetBeamElementList().Count;
                else dataGridView1.Rows[i].Cells[2].Value = "-";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshStorey();
            label7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
        }
    }
}
