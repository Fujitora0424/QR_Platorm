using MetroFramework;
using MetroFramework.Forms;
using QR_Tool_Winform.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json.Converters;
using QR_Tool_Winform.View;

namespace QR_Tool_Winform
{
    public partial class TestConfigForm : MetroForm
    {
        string con_file_path = Application.StartupPath + "\\Config\\" + "config.json";
        public TestConfigForm()
        {
            InitializeComponent();
            cbDeviceTypeSelect.SelectedIndex = 2;
        }

        private void TestConfigForm_Load(object sender, EventArgs e)
        {
            StartForm sf = new StartForm();
            sf.ShowDialog();

            if (!File.Exists(con_file_path))
            {
                File.Create(con_file_path);
            }
            using (StreamReader sr = new StreamReader(con_file_path))
            {
                try
                {

                    string sconfig  = sr.ReadToEnd();
                    Dictionary<string, object> dic = JsonHelper.DeserializeJsonToObject<Dictionary<string, object>>(sconfig);
                    if (dic != null)
                    {
                        cbEncoding.SelectedItem = dic["Encoding"];
                        txbMacQRcode.Text = dic["MaxQR"].ToString();
                         tbBackUrl.Text = dic["BackUrl"].ToString();
                         txbUnqiueNumber.Text =dic["ReqReserved"].ToString(); 
                         tbQRAPPIP.Text =  dic["PhoneIp"].ToString();
                        tbQRPlatformUrl.Text = dic["PlatformUrl"].ToString();
                       cbDeviceTypeSelect.SelectedItem = dic["DeviceType"].ToString();

                    }

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message);
                }
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool setflag = true;
            if(!cbDeviceTypeSelect.SelectedItem.ToString().Equals(""))
            {
                switch(cbDeviceTypeSelect.SelectedItem.ToString())
                {
                    case "POS":
                        TestConfig.NowDeviceDataTable = Parameters.dtPOSTestCase;
                        break;
                    case "OfflineDevice":
                        TestConfig.NowDeviceDataTable = Parameters.dtOfflineDeviceCase;
                        break;
                    case "OnlineDevice":
                        TestConfig.NowDeviceDataTable = Parameters.dtOnlineDeviceCase;
                        break;
                    default:
                        MetroMessageBox.Show(this, "无匹配案例");
                        break;
                      

                }
                TestConfig.TestCaseTitle = cbDeviceTypeSelect.SelectedItem.ToString();




            }
            else
            {

                MetroMessageBox.Show(this, "设备类型不能为空");
                setflag = false;
            }
            if (!cbEncoding.SelectedItem.ToString().Equals(""))
            {
                
               Field.Encoding = cbEncoding.SelectedItem.ToString();

            }
            else
            {

                MetroMessageBox.Show(this, "编码类型不能为空");
                setflag = false;
            }
            if (txbMacQRcode.Text.Trim()!="")
            {
                int number = int.Parse(txbMacQRcode.Text.Trim());
                if(number<100)
                {

                    MetroMessageBox.Show(this, "个数不能小于100");
                    setflag = false;
                }
                else
                {
                    TestConfig.MacQRCode = number;
                }


            }
            else
            {

                MetroMessageBox.Show(this, "最大二维码个数不能为空");
                setflag = false;

            }
            if (txbUnqiueNumber.Text.Trim() != "")
            {


                Field.ReqReserved = txbUnqiueNumber.Text.Trim();
            

            }
            else
            {
                Field.ReqReserved = "";

            }
            if (!tbBackUrl.Text.Trim().Equals(""))
            {


                Field.BackUrl = tbBackUrl.Text.Trim();


            }
            else
            {

                Field.BackUrl = "null";

            }

            if (tbQRAPPIP.Text.Trim() != "")
            {

                Parameters.phoneIP = tbQRAPPIP.Text.Trim();
               


            }
            else
            {

                MetroMessageBox.Show(this, "手机监听IP不能为空");
                setflag = false;

            }
            if (tbQRPlatformUrl.Text.Trim() != "")
            {

                Parameters.platformUrl= tbQRPlatformUrl.Text.Trim();



            }
            else
            {

                MetroMessageBox.Show(this, "平台URL不能为空");
                setflag = false;

            }


            if (setflag)
            {
                using (StreamWriter sw = new StreamWriter(con_file_path))
                {
                    try
                    {

                            
                        //把模型数据序列化并写入Json.net的JsonWriter流中  
                        Dictionary<string, object> wr_Dic = new Dictionary<string, object>();
                        wr_Dic.Add("Encoding", Field.Encoding);
                        wr_Dic.Add("BackUrl", Field.BackUrl);
                        wr_Dic.Add("ReqReserved", Field.ReqReserved);
                        wr_Dic.Add("PhoneIp", Parameters.phoneIP);
                        wr_Dic.Add("PlatformUrl", Parameters.platformUrl);
                        wr_Dic.Add("MaxQR", TestConfig.MacQRCode);
                        wr_Dic.Add("DeviceType", TestConfig.TestCaseTitle);
                        string sConfig = JsonHelper.SerializeObject(wr_Dic);
                        sw.Write(sConfig);
                        sw.Close();

                    }
                    catch(Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message);

                    }


}



                this.Close();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void TestConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void txbMacQRcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            { e.Handled = false; }
        }
    
    }
}
