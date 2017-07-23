using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;
using QR_Tool_Winform.Metro_UI_Tools;
using System.Net;
using QR_Tool_Winform.Message;
using QR_Tool_Winform.Global;
using System.Linq;
using System.Data.SQLite;
using QR_Tool_Winform.DataBase;
using MetroFramework.Forms;

using MetroFramework;
using QR_Tool_Winform.View;

namespace QR_Tool_Winform
{
    public partial class MainWindow : MetroForm
    {
        

        #region 控件指示位
        public bool IsResponse = true;              //响应数据
        public bool ListenFlag = true;              //监听数据开关
        #endregion
        #region 变量声明
        public ImageList ImageForCase;                        //案例通过与否图片集
        int ListenPort = 8000;                  //端口号
        Thread Thread_receive;                  //通讯进程
        public static TreeNode RightClickNode = null;
        public static TreeView RightClickView = null;
        public static int CaseTransNo = 0;                  //报文序号
        public static string SelectCaseName = "";          //选择的案例号
        public static int CaseState = -1;           //表示案例是否测试完毕,0：开始测试 1：测试开始 -1：未开始测试
        public ShowResult DelegateShowResult = null;    //案例说明窗体
        private HttpListener newlistener;
        delegate void SetTextCallback(string text, Color textcolor);     
        delegate void SetQRCallback(TreeView tv, string title,string key, string value, string name, int level, Color textcolor);
        delegate TreeView GreatePageCallBack(TabControl tc);
        delegate MetroFramework.Controls.MetroGrid GreatePageCallBackGird(TabControl tc);
        delegate void SetQRCallbackGird(MetroFramework.Controls.MetroGrid tv,DataTable dt);
        delegate void SetPageNameCallBack(string str, TabControl tc);
        delegate void SetButtonCallback(string text, bool Enable);
        delegate void SetCaseFlagCallback(int imgIndex);
        delegate DialogResult SetCaseResultCallBack(string str);
        delegate void SetnumberCallBack(int i);//存储量计数器的委托
        delegate void SetTreeViewUpdateCallBack(TreeView Tv, int i);
        delegate void SetConnectStatueCallBack(string text);
        delegate void ClearMessagePageCallBack();
        #endregion

        public void ClearMessagePage()
        {

            if (ReceiveText.InvokeRequired&& SendText.InvokeRequired)
            {
                ClearMessagePageCallBack d = new ClearMessagePageCallBack(ClearMessagePage);
                this.Invoke(d, new object[] {  });
            }
            else
            {

                ReceiveText.Controls.Clear();
                SendText.Controls.Clear();

            }


        }


    

        public void SetErrorText(string text, Color textcolor)
        {
            if (this.ErrorText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetErrorText);
                this.Invoke(d, new object[] { text, textcolor });
            }
            else
            {
                if (text.Trim() != "")
                {
                    int zero = this.ErrorText.Text.Length;
                    if (textcolor == Color.Red)
                    {
                        this.ErrorText.AppendText("第" + CaseTransNo.ToString() + "笔交易错误信息如下：\r\n" + text + "\r\n");
                    }
                    else
                    {
                        this.ErrorText.AppendText(text + "\r\n");
                    }
                    this.ErrorText.Select(zero, this.ErrorText.Text.Length);
                    this.ErrorText.SelectionColor = textcolor;
                    if (Project.ProjectPath.Trim() != "" && SelectCaseName.Trim() != "" && SelectCaseName.Trim() != "" && CaseState == 1 && text.Trim() != "")
                    {
                        StreamWriter sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", true);
                        sw.Write("错误信息：" + text + "\r\n");
                        sw.Close();
                    }
                    //else if (SelectCaseName.Trim() != "" && CaseState == 1)
                    //{
                    //    CaseState = 1;
                    //    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "Log" + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", false);
                    //    sw.Write("错误信息：" + text + "\r\n");
                    //    sw.Close();

                    //}
                    else
                    {
                        Trace.SaveDefaultTrace(text, 1, "");
                    }
                    this.ErrorText.Focus();
                    this.ErrorText.Select(this.ErrorText.TextLength, 0);
                    this.ErrorText.ScrollToCaret();
                }
            }
        }
     

        public void SetCaseText(TreeNodeCollection fnode, int intParentID)
        {
          
                try
                {
                  DataTable dt =TestConfig.NowDeviceDataTable ;
               

                    foreach (DataRow row in dt.Select(String.Format("ParentID = {0}", intParentID)))
                    {

                        TreeNode Tnnode = new TreeNode();
                        Tnnode.Text = row["NodeText"].ToString()+ (row["Character"].ToString().Equals("Node")?"":'【' + row["Character"].ToString() + '】');
                        Tnnode.Tag = row;
                        this.SetCaseText(Tnnode.Nodes, Convert.ToInt32(row["ID"]));
                        fnode.Add(Tnnode);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
         }
      
        public void SetConnectStatue(string text) 
        {

            if (this.InvokeRequired)
            {
                SetConnectStatueCallBack d = new SetConnectStatueCallBack(SetConnectStatue);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Trim() != "")
                {
                    connectStatus.Text = text.Trim();


                }
               
            
            
            }
        
        
        
        }
        public void SetQRCount(string text)
        {

            if (this.InvokeRequired)
            {
                SetConnectStatueCallBack d = new SetConnectStatueCallBack(SetQRCount);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Trim() != "")
                {
                    txbQRCount.Text = text.Trim();

                }



            }



        }
        #region  显示解析       
        public void SetQRReceiveTextGird(MetroFramework.Controls.MetroGrid tv,DataTable dt)
        {
           
            if (tv.InvokeRequired)
            {
                SetQRCallbackGird d = new SetQRCallbackGird(SetQRReceiveTextGird);
                this.Invoke(d, new object[] { tv, dt });
            }
             else
            {
                tv.DataSource =dt;
      
                tv.RowHeadersVisible = false;
                //tv.AllowUserToAddRows = false;
            }

        }
        public void SetQRSendTextGird(MetroFramework.Controls.MetroGrid tv, DataTable dt)
        {

            if (tv.InvokeRequired)
            {
                SetQRCallbackGird d = new SetQRCallbackGird(SetQRSendTextGird);
                this.Invoke(d, new object[] { tv, dt });
            }
            else
            {
                tv.DataSource = dt;
                tv.RowHeadersVisible = false;
               
            }

        }
        #endregion
        public void SetPageName(string str, TabControl tc)
        {
            if (tc.InvokeRequired)
            {
                SetPageNameCallBack d = new SetPageNameCallBack(SetPageName);
                this.Invoke(d, new object[] { str, tc });
            }
            else
            {
                if (tc.Equals(ReceiveText))
                {
                    str += "请求";
                }
                else
                {
                    str += "响应";
                }
                tc.Controls[tc.Controls.Count - 1].Text = str;
            }
        }
        public void SetButton1(string text, bool Enable)
        {
            if (this.ListenButton.InvokeRequired)
            {
                SetButtonCallback d = new SetButtonCallback(SetButton1);
                this.Invoke(d, new object[] { text, Enable });
            }
            else
            {
                this.ListenButton.Enabled = Enable;
                this.ListenButton.Text = text;
            }
        }
        public void SetButton2(string text, bool Enable)
        {
            if (this.StopListenButton.InvokeRequired)
            {
                SetButtonCallback d = new SetButtonCallback(SetButton2);
                this.Invoke(d, new object[] { text, Enable });
            }
            else
            {
                this.StopListenButton.Enabled = Enable;
                this.StopListenButton.Text = text;
            }
        }
        public void SetPort(string text, bool Enable)
        {
            if (this.txbPCPort.InvokeRequired)
            {
                SetButtonCallback d = new SetButtonCallback(SetPort);
                this.Invoke(d, new object[] { text, Enable });
            }
            else
            {
                this.txbPCPort.Enabled = Enable;
            }
        }      
        public void SetCaseFlag(int ImageIndex)
        {
           
                if (tvTestCase.InvokeRequired)
                {
                SetCaseFlagCallback d = new SetCaseFlagCallback(SetCaseFlag);
                  this.Invoke(d, new object[] { ImageIndex });
                }
                else
                {
                tvTestCase.SelectedNode.ImageIndex = -1;
                tvTestCase.SelectedNode.SelectedImageIndex = -1;
                tvTestCase.SelectedNode.ImageIndex = ImageIndex;
                tvTestCase.SelectedNode.SelectedImageIndex = ImageIndex;
                    if (Project.ProjectPath.Trim() != "" && SelectCaseName.Trim() != "" && SelectCaseName.Trim() != "" && (ImageIndex == 1 || ImageIndex == 2))
                    {
                        StreamReader sr = new StreamReader(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt");
                        string LOGSave = sr.ReadToEnd();
                        sr.Close();
                        string CaseResult = ImageIndex == 1 ? "PASS" : "FAIL";
                        StreamWriter sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", false);
                        sw.Write("案例号：" + SelectCaseName + "\r\n##Result=" + CaseResult + "\r\n" + LOGSave);
                        sw.Close();
                        sr = new StreamReader(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\ProjectTestConfig.json");
                        string Config = sr.ReadToEnd();
                         sr.Close();
                        ResultConfig rc = JsonHelper.DeserializeJsonToObject<ResultConfig>(Config);
                        rc.result[SelectCaseName] = (ImageIndex == 1 ? "PASS" : "FAIL");
                         string writeConfig  = JsonHelper.SerializeObject(rc);                    
                         sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\ProjectTestConfig.json", false);
                         sw.Write(writeConfig);
                          sw.Close();
                    }
                    CaseState = 0;
                }
           
        }
   
   
        public string CaseResult(string Message)
        {
            string reMessage = "";
            ShowResult  show = new ShowResult(Message);
        
            show.ShowDialog();
            reMessage= show.GetResultMessage();
            show.Dispose();
            return reMessage;

        }  //防止进程阻塞，加入的判断pass/FAIL
        public MainWindow()
        {
            InitializeComponent();
            TestConfigForm tcf = new TestConfigForm();
            if (tcf.ShowDialog() == DialogResult.OK)
            {
                btnTestCase.Text += "-" + TestConfig.TestCaseTitle;
            }
            else
            {
                System.Environment.Exit(0);
            }
           


        }

       

        public void NewProject(object sender, EventArgs e)//新建工程
        {
            Project pnew = new Project();
            pnew.ShowDialog();
        }
        public void Listen(object sender, EventArgs e)//开始监听
        {     
                try
            {
                if (txbPCPort.Text.Trim() != "")
                {
                    if (Convert.ToInt32(txbPCPort.Text) < 0 || Convert.ToInt32(txbPCPort.Text) > 65535)
                    {
                        MessageBox.Show("请输入正确的端口号");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请输入端口号");
                    return;
                }
                ListenPort = Convert.ToInt32(txbPCPort.Text);
                if (Tools.PortinUse(ListenPort)) {

                    MessageBox.Show(ListenPort.ToString()+"被占用，请使用其他端口");
                    return;
                }
                else
                {
                    txbPCPort.Enabled = false;
                    ListenButton.Text = "监听中";
                    ListenButton.Enabled = false;
                    StopListenButton.Text = "停止监听";
                    StopListenButton.Enabled = true;
                    ListenPort = Convert.ToInt32(txbPCPort.Text);
                    ListenFlag = true;
                    string url = string.Format("https://+:{0}/", ListenPort);//后续可能会改成http，修改https为http即可，注意修改
                    //netsh http add urlacl url=https://+:ListenPort/ user=***
                    //netsh http add sslcert ipport=0.0.0.0:6667 appid={ebfffbdf-ae61-4a86-9a2e-7f89b3cb1a5e} certhash=f7f8f6695149ec87a4e8f78945f38195e333bd5a usagecheck=disable verifyclientcertrevocation=disable
                    newlistener = new HttpListener();
                    newlistener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
                    newlistener.Prefixes.Clear();
                    newlistener.Prefixes.Add(url); //添加需要监听的url范围，Prefixes可添加多个
                    newlistener.Start(); //开始监听端口，接收客户端请求
                    Thread_receive = new Thread(new ThreadStart(MessageReceiveAndSend));
                    Thread_receive.Start();
                    SetConnectStatue("正在监听");
                
                }
            }
            catch (Exception ex)
            {
                ErrorText.Text += ex.Message + "\r\n";
                ListenButton.Text = "监听";
                ListenButton.Enabled = true;
                txbPCPort.Enabled = true;
            }
        }
        public void MessageReceiveAndSend()//监听线程
        {
            try
            {

                bool result = false;
                while (ListenFlag)
                {


                 
                    HttpListenerContext context = newlistener.GetContext(); //等待请求连接,没有请求则GetContext处于阻塞状态
                    HttpListenerRequest request = context.Request; //客户端发送过来的消息
                    Parameters.MessageEncode.encValue = Encoding.GetEncoding(Field.Encoding);
                    var reader = new StreamReader(request.InputStream, Parameters.MessageEncode.encValue);
                    var req_msg = reader.ReadToEnd();
                    Dictionary<string, string> req_Dic = UP_SDK.SDKUtil.CoverStringToDictionary(req_msg, Parameters.MessageEncode.encValue);      
                    CaseTransNo++;
                    string errorMessage = "";
                    MainWindow mw = this;
                    QRMessage ms = new QRMessage(req_Dic);
                    if (Project.ProjectPath.Trim() != "" && SelectCaseName.Trim() != "" && CaseState == 0)
                    {
                        CaseState = 1;
                        StreamWriter sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", false);
                        sw.Write("");
                        sw.Close();
                    }
                   
                    else
                    {
                        Trace.SaveDefaultTrace("",0,ms.GetMessageName());

                    }


                    string selectCaseType = "";
                    if(!SelectCaseName.Equals(""))
                    {
                        selectCaseType = SelectCaseName.Substring(0, 3);
                    }
                    switch (selectCaseType)
                    {

                        #region 联机非POS设备案例
                        case "OLD":
                            string munualMessage = "";
                            if (CaseTransNo == 1)
                            {
                                result = true;
                            }
                            if (!OnlineDeviceTestCase.RunTestCase( ms,  context.Response, ref CaseTransNo, ref mw, ref errorMessage,SelectCaseName,ref munualMessage))
                            {
                                result = false;
                                SetCaseFlag(2);
                                continue;
                            }
                            if (CaseTransNo == 0 && result)
                            {
                                if(!munualMessage.Equals(""))
                                {
                                    string errorMunualResult = CaseResult(munualMessage);
                                    if (errorMunualResult.Equals(""))
                                    {
                                        SetCaseFlag(1);
                                    }
                                    else
                                    {
                                        SetErrorText(errorMunualResult, Color.Red);
                                        SetCaseFlag(2);
                                    }
                                }                            
                                else
                                {
                                    SetCaseFlag(1);
                                }
                            }
                            break;
                        #endregion
          

                        default:
                            CaseTransNo = 0;
                            //接收检测，接收显示，参数处理，应答显示，应答
                            ms.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);

                            string MessageName = ms.GetMessageName();
                            Encoding req_encode = ms.GetMessageEncoding();
                           
                          

                            //应答初始化
                            string ResponseMessage = null;
                            Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                            if (IsResponse)//判断是否应答
                            {
                                bool isCorrect= true;
                                switch (MessageName)
                                {

                                    case "申请二维码":
                                        res_Dic = ms.PackageResponseMessage_Apply_BarCode("https://qr.95516.com/00010001/62203343506412524330099992411134", ARCset.Text, Tools.GetRespMsg(ARCset.Text), "未完成",null,"" ,ref isCorrect, ref errorMessage);
                                        ms.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                                        ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_encode);
                                        break;
                                    case "APP消费":
                                        res_Dic = ms.PackageResponseMessage_ReAPP_Sale("00", null, ref isCorrect, ref errorMessage);
                                        ms.ShowResponseMessage(ref mw, CaseTransNo,  res_Dic, ref errorMessage);
                                        ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_encode);
                                        break;
                                    case "交易状态查询":
                                        res_Dic = ms.PackageResponseMessage_Transaction_Status_Query(ARCset.Text, Tools.GetRespMsg(ARCset.Text), "05", Tools.GetRespMsg("05"), null,"",ref isCorrect, ref errorMessage);
                                        ms.ShowResponseMessage(ref mw, CaseTransNo,  res_Dic, ref errorMessage);
                                        ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_encode);
                                        break;
                                    case "消费撤销":
                                        res_Dic = ms.PackageResponseMessage_Consumption_Revocation(ARCset.Text, Tools.GetRespMsg(ARCset.Text), "完成", null,"", ref isCorrect,  ref errorMessage);
                                        ms.ShowResponseMessage(ref mw, CaseTransNo,  res_Dic, ref errorMessage);
                                        ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_encode);
                                        break;
                                    case "退货":
                                        res_Dic = ms.PackageResponseMessage_Refund(ARCset.Text, Tools.GetRespMsg(ARCset.Text), "完成", null, "",ref isCorrect, ref errorMessage);
                                        ms.ShowResponseMessage(ref mw, CaseTransNo,  res_Dic, ref errorMessage);
                                        ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_encode);
                                        break;



                                }
                                if (errorMessage.Trim() != "")
                                {
                                    errorMessage = MessageName + "错误信息:\r\n" + errorMessage;
                                }
                                if (ResponseMessage != null)
                                {
                                    bool sendFlag = ms.SendMessage(ref mw, ResponseMessage, context.Response, 200, Parameters.MessageEncode.encValue);
                                    if (!sendFlag)
                                    {

                                        SetErrorText(MessageName + "报文未能正确发送", Color.Red);
                                    }

                                }
                                else
                                {
                                    SetErrorText(MessageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                                }
                            }
                            else 
                            {
                                SetErrorText(MessageName + "报文不响应，原因：人工关闭了响应报文开关。", Color.Red);
                            }
                           
                           
                         
                            if (errorMessage.Trim() != "")
                            {
                                SetErrorText(errorMessage, Color.Red);

                            }
                            
                            break;
                         
                    }
                }

                //案例测试end

                if (!ListenFlag)
                {

                    SetConnectStatue("停止监听");

                }
            }
            catch(Exception e)
            {
                SetConnectStatue("停止监听");
                ListenFlag = false;

                if (newlistener != null)
                {
                    if (newlistener.IsListening)
                    {
                        newlistener.Stop();
                    }
                    newlistener.Close();
                }
                Trace.WriteWrongTrace(e.Message);//获取错误信息
                return;

            }
   }


        void ButtonClick(object sender, System.EventArgs e)
        {
            // Get the clicked button...
            Button clickedButton = (Button)sender;
            // ... and it's tabindex
            int clickedButtonTabIndex = clickedButton.TabIndex;

            // Send each button to top or bottom as appropriate
            foreach (Control ctl in CaseAndControlPanel.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = (Button)ctl;
                    if (btn.TabIndex > clickedButtonTabIndex)
                    {
                        if (btn.Dock != DockStyle.Bottom)
                        {
                            btn.Dock = DockStyle.Bottom;
                            // This is vital to preserve the correct order
                            btn.BringToFront();
                        }
                    }
                    else
                    {
                        if (btn.Dock != DockStyle.Top)
                        {
                            btn.Dock = DockStyle.Top;
                            // This is vital to preserve the correct order
                            btn.BringToFront();
                        }
                    }
                }
            }

            // Determine which button was clicked.
            switch (clickedButton.Text.Substring(0,2))
            {
                
                case "测试":
                    ControlPannel.Visible = false;
                    TestCasePanel.Visible = true;
                    TestCasePanel.BringToFront();
                    break;               
                case "设置":
                    TestCasePanel.Visible = false;
                    ControlPannel.Visible = true;
                    ControlPannel.BringToFront();
                    break;
            }
           
        }




       

        public void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {


                //屏幕适配
            lbARC.Width = lbResponseStatus.Width =lbPCPort.Width =(int) (gpbPlaform.Width * 0.2);
            txbPCPort.Left = lbPCPort.Left + lbPCPort.Width + (int)(gpbPlaform.Width * 0.1);
           txbPCPort.Width = gpbPlaform.Width - txbPCPort.Left-10 ;
            lbAppPort.Width = (int)(gpbApp.Width * 0.3);
            tgResponse.Left = ARCset.Left = PhoneIP.Left = txbPCPort.Left;
            tgResponse.Width = ARCset.Width = PhoneIP.Width = txbPCPort.Width;
            btnShowLog.Height = btnUpdateLog.Height = btnDelectLog.Height =(int)( logGroupBox.Height * 0.5);

           lbARC.Width = lbResponseStatus.Width = lbPCPort.Width;
                //案例加载
             SetCaseText(tvTestCase.Nodes, 0);
            ImageForCase = new ImageList();
            ImageForCase.Images.Add(global::QR_Tool_Winform.Properties.Resources.page);
            ImageForCase.Images.Add(global::QR_Tool_Winform.Properties.Resources.pass);
            ImageForCase.Images.Add(global::QR_Tool_Winform.Properties.Resources.fail);
            tvTestCase.ImageList = ImageForCase;
            tvTestCase.ImageIndex = 0;
            tvTestCase.ImageList = ImageForCase;
            tvTestCase.ImageIndex = 0;
            tvTestCase.ImageList = ImageForCase;
            tvTestCase.ImageIndex = 0;
            //全局参数设置
            PhoneIP.Text = Global.Parameters.phoneIP;
           Parameters.dtDictionnary = Dictionary.GetDictionaryTable("Full_Chinnal_Interface_Data");
           Parameters.dtResponse = Dictionary.GetDictionaryTable("Response");
            Parameters.dtOnlineDeviceTestCaseList = Dictionary.GetDictionaryTable("OnlineDeviceTestCase");
                //加载数据库
           cbDataBase.SelectedIndex = 0;
           logGrid.DataSource = Log.GetDictionaryTable(cbDataBase.SelectedItem.ToString());
           logGrid.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
           logGrid.AllowUserToAddRows = false;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                
            }
        }
        public void MainWindow_SizeChanged(object sender, EventArgs e)
        {

            lbPCPort.Width = (int)(gpbPlaform.Width * 0.2);
            txbPCPort.Left = lbPCPort.Left + lbPCPort.Width + (int)(gpbPlaform.Width * 0.1);
            txbPCPort.Width = gpbPlaform.Width - txbPCPort.Left - 10;
            lbAppPort.Width = (int)(gpbApp.Width * 0.2);
            PhoneIP.Left = txbPCPort.Left;
            PhoneIP.Width = txbPCPort.Width;
            tgResponse.Left = ARCset.Left = PhoneIP.Left = txbPCPort.Left;
            tgResponse.Width = ARCset.Width = PhoneIP.Width = txbPCPort.Width;
            lbARC.Width = lbResponseStatus.Width = lbPCPort.Width;
            btnShowLog.Height = btnUpdateLog.Height = btnDelectLog.Height = (int)(logGroupBox.Height * 0.5);
        }
  
        public void StopListenButton_Click(object sender, EventArgs e)//停止监听
        {
      
            
            ListenFlag = false;

            if (newlistener != null)
            {
                if (newlistener.IsListening)
                {
                    newlistener.Stop();
                }
                newlistener.Close();
            }
            if (Thread_receive!= null)
            {
                Thread_receive.Abort();
            }
           
            SetButton1("监听", true);
            SetButton2("停止监听", false);
            SetPort("", true);
        }
        public MetroFramework.Controls.MetroGrid CreateNewPageGird(TabControl ReceiveOrSend)
        {
            if (ReceiveOrSend.InvokeRequired)
            {
                GreatePageCallBackGird d = new GreatePageCallBackGird(CreateNewPageGird);
                return (MetroFramework.Controls.MetroGrid)this.Invoke(d, new object[] { ReceiveOrSend });
            }
            else
            {
                if(ReceiveOrSend.TabCount==12)
                {

                    ClearMessagePage();

                }
                MetroFramework.Controls.MetroTabPage Tp = new MetroFramework.Controls.MetroTabPage();
                MetroFramework.Controls.MetroGrid Tv = new MetroFramework.Controls.MetroGrid();
                ReceiveOrSend.Controls.Add(Tp);
                Tp.Controls.Add(Tv);
                Tv.Dock = DockStyle.Fill;
                Tv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Tv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                Tv.RowsDefaultCellStyle.WrapMode = (DataGridViewTriState.True);
                Tv.CellBorderStyle =
                DataGridViewCellBorderStyle.Sunken;
                Tv.RowHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;
                Tv.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.Single;
                Tv.AllowUserToAddRows = false;
                Tp.Padding = new Padding(5, 5, 0, 0);
                Tv.ContextMenuStrip = MessageClickMenu;
                ReceiveOrSend.SelectedTab = Tp;
                return (MetroFramework.Controls.MetroGrid)ReceiveOrSend.Controls[ReceiveOrSend.Controls.Count - 1].Controls[ReceiveOrSend.Controls[ReceiveOrSend.Controls.Count - 1].Controls.Count - 1];
            }
        }

        public void TreeViewExpand_Click(object sender, EventArgs e)
        {
           
            if (RightClickNode != null)
            {
                RightClickNode.Expand();
            }
            else
            {
                if (RightClickView != null)
                {
                    RightClickView.ExpandAll();
                }
            }
        }
        public void TreeViewCollapse_Click(object sender, EventArgs e)
        {
         
            if (RightClickNode == null)
            {
                if (RightClickView != null)
                {
                    RightClickView.CollapseAll();
                }
            }
            else
            {
                RightClickNode.Collapse();
            }
        }
        public void ResponseTrue_CheckedChanged(object sender, EventArgs e)
        {
            IsResponse = true;
        }
        public void ResponseFalse_CheckedChanged(object sender, EventArgs e)
        {
            IsResponse = false;
        }
        public void ClearMessage_Click(object sender, EventArgs e)
        {
            ReceiveText.Controls.Clear();
            SendText.Controls.Clear();
            
        }
       
   

        private void CaseText_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CaseTransNo = 0;
          
            if (tvTestCase.SelectedNode.Parent != null)
            {
              
                string caseName = tvTestCase.SelectedNode.Text;
                caseName = caseName.Substring(0, caseName.IndexOf("【"));
                if (caseName != "")
                {
                  
                    SelectCaseName = caseName;
                    CaseState = 0;
                    var testCaseContent ="";
                    try
                    {
                         testCaseContent = (string)Parameters.dtOnlineDeviceTestCaseList.Select(String.Format("testCaseName = '{0}'", caseName))[0]["testCaseContent"];
                    }
                    catch
                    {
                        testCaseContent = "不存在";
                    }
                    if (testCaseContent != null)
                    {

                        rtbTestCaseContent.Text = testCaseContent.ToString();
                        gbTestCaseContent.Text = caseName + "案例描述";
                        if(caseName.Equals("OLD_TSTA001"))
                        {
                            gbTestcasecontrol.Visible = true;
                            TestConfig.StableTest = true;
                            SetQRCount(Log.GetDictionaryTable("StableLog").Rows.Count.ToString());

                        }
                        else
                        {

                            gbTestcasecontrol.Visible =false;
                            TestConfig.StableTest = false;
                        }
                        
                    }
                }
                else
                {
                    SelectCaseName = "";
                    CaseState = -1;
             
                }
            }
            else
            {
                gbTestCaseContent.Text =  "案例描述";
                rtbTestCaseContent.Text = "";
                SelectCaseName = "";
                CaseState = -1;
                //DelegateFormCase = null;
            }

        }
        private void ErrorCleanUp_Click(object sender, EventArgs e)
        {
            ErrorText.Clear();
        }
        private void CreateProject_Click(object sender, EventArgs e)
        {
            Project pj = new Project();
            pj.mw = this;
            pj.Show();
        }
        public void SetProjectState(string str)
        {
            projectStatus.Text = str;
        }
  
      
        private void OpenProject_Click(object sender, EventArgs e)
        {
            if (FindProject.ShowDialog() == DialogResult.OK)
            {

                
                FileInfo fi = new FileInfo(FindProject.SelectedPath + "\\ProjectTestConfig.json");
                if (fi.Exists)
                {
                
           
                    StreamReader sr = new StreamReader(FindProject.SelectedPath + "\\ProjectTestConfig.json");
                    string ConfigStr = sr.ReadToEnd();
                    sr.Close();
                    ResultConfig rc = JsonHelper.DeserializeJsonToObject<ResultConfig>(ConfigStr);
                    Project.ProjectName = rc.projectName;
                    Project.ProjectPath = FindProject.SelectedPath.Replace("\\" + Project.ProjectName, "");
                    projectStatus.Text = Project.ProjectName;
                    string CaseName = "";
                    string Result = "";
                    foreach(var item in rc.result)
                    {
                        CaseName = "";
                        Result = "";
                        CaseName = item.Key;
                        Result = item.Value;
                        if (CaseName != "")
                        {
                            bool flag = false;
                            foreach (TreeNode tn in tvTestCase.Nodes)
                            {
                                if (tn.Nodes.Count>0)
                                {
                                    foreach (TreeNode tnchild in tn.Nodes)
                                    {
                                        if (tnchild.Text.Contains(CaseName))
                                        {
                                            tnchild.ImageIndex = -1;
                                            tnchild.SelectedImageIndex = -1;
                                            tnchild.ImageIndex = Result == "PASS" ? 1 : 2;
                                            tnchild.SelectedImageIndex = Result == "PASS" ? 1 : 2;
                                            flag = true;
                                            break;
                                        }
                                    }
                                    if (flag)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                     
                    }
                }
                else
                {


                    DialogResult dr = MetroMessageBox.Show(this, "配置文件不存在，是否新建", "提示", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        using (FileStream fs = new FileStream(FindProject.SelectedPath + "\\ProjectTestConfig.json", FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {

                                Global.ResultConfig rc = new Global.ResultConfig();
                                rc.projectName = FindProject.SelectedPath.Substring(FindProject.SelectedPath.LastIndexOf("\\")+1, FindProject.SelectedPath.Length- FindProject.SelectedPath.LastIndexOf("\\") - 1);
                                string str = JsonHelper.SerializeObject(rc);
                                sw.Write(str);
                                sw.Close();

                            }
                        }
                    }




                 
                }
            }
        }
        private void ARCset_TextChanged(object sender, EventArgs e)
        {
            char[] CheckChar = ARCset.Text.Trim().ToCharArray();
            int CharNum = 0;
            foreach (char tempchar in CheckChar)
            {
                if ((tempchar >= '0' && tempchar <= '9') || (tempchar >= 'a' && tempchar <= 'f') || (tempchar >= 'A' && tempchar <= 'F'))
                {
                    CharNum++;
                }
                else
                {
                    MessageBox.Show("输入不符合要求");
                    ARCset.Text = "00";
                }
            }
            if (CharNum != 2)
            {
                MessageBox.Show("响应码应输入两位");
                ARCset.Text = "00";
            }
        }
        private void CloseProject_Click(object sender, EventArgs e)
        {
            Project.ProjectName = "";
            Project.ProjectPath = "";
            projectStatus.Text = "未加载";
            foreach (TreeNode tn in tvTestCase.Nodes)
            {
                foreach (TreeNode tnchild in tn.Nodes)
                {
                    tnchild.ImageIndex = -1;
                    tnchild.SelectedImageIndex = -1;
                }
            }
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            if (SelectCaseName.Trim() != "")
            {
                this.tvTestCase.SelectedNode.ImageIndex = 1;
                this.tvTestCase.SelectedNode.SelectedImageIndex = 1;
            }
            else 
            {
                MessageBox.Show("未选择案例");
            
            }
        }

        private void Fail_Click(object sender, EventArgs e)
        {
            if (SelectCaseName.Trim() != "")
            {
                this.tvTestCase.SelectedNode.ImageIndex = 2;
                this.tvTestCase.SelectedNode.SelectedImageIndex = 2;
            }
            else
            {
                MessageBox.Show("未选择案例");

            }
        }

      

       

   

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }





      
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ControlTab_Click(object sender, EventArgs e)
        {

        }


     

        private void ResponseOrNotGroup_Enter(object sender, EventArgs e)
        {

        }

        private void PhoneIP_TextChanged(object sender, EventArgs e)
        {
            Global.Parameters.phoneIP = PhoneIP.Text.Trim();
        }

        private void ErrorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ProjectStateLabel_Click(object sender, EventArgs e)
        {

        }

        private void logGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      

        private void databaseTabPage_Click(object sender, EventArgs e)
        {

        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void phoneToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(phoneToggle.Checked)
            {
                Parameters.phoneToggle = true;

            }
            else
            {
                Parameters.phoneToggle = false;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            bool isSquenec;
            if (cbDataBase.SelectedItem.ToString().Equals("StableLog"))
            {
                isSquenec = true;
            }
            else
            {
                isSquenec = false;

            }
            Log.DeleteALLLog(cbDataBase.SelectedItem.ToString(), isSquenec);
        }

        private void btnUpdateLog_Click(object sender, EventArgs e)
        {
            var source = this.logGrid.DataSource;
            DataTable dt = (DataTable)source;
            Log.UpdateLog(dt, cbDataBase.SelectedItem.ToString());
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            this.logGrid.DataSource = Log.GetDictionaryTable(cbDataBase.SelectedItem.ToString());
        }

        private void 更新案例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseSelect fcs = new FormCaseSelect();
            DialogResult re = fcs.ShowDialog();
            if(re == DialogResult.OK)
            {
                FormCaseManage fm = new FormCaseManage(Parameters.dbTestCaseSoure);
                fm.ShowDialog();
            }
        }

        private void lbAppPort_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 更新案例描述ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaseSelect fcs = new FormCaseSelect();
            DialogResult re = fcs.ShowDialog();
            if (re == DialogResult.OK)
            {
                FormCaseContent fm = new FormCaseContent(Parameters.dbTestCaseSoure);
                fm.ShowDialog();
            }
        }

        private void PassMenu_Click(object sender, EventArgs e)
        {
            tvTestCase.ExpandAll();
        }

        private void FailMenu_Click(object sender, EventArgs e)
        {
            tvTestCase.CollapseAll();
        }

        private void 查看日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvTestCase.SelectedNode.Parent != null)
            {

                string caseName = tvTestCase.SelectedNode.Text;
                caseName = caseName.Substring(0, caseName.IndexOf("【"));
                if (caseName != "")
                {

                    string[] allMatchFiles = Directory.GetFiles(  Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\", caseName + ".txt", SearchOption.TopDirectoryOnly);
                    if (allMatchFiles.Length > 0)
                    {
                        System.Diagnostics.Process.Start(allMatchFiles[allMatchFiles.Length - 1]); 
                   }


                }
            }
               
            }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (tgResponse.Checked)
            {
                IsResponse = true;

            }
            else
            {
                IsResponse = false;
            }
        }

        private void ARCset_Click(object sender, EventArgs e)
        {

        }
    }
}
