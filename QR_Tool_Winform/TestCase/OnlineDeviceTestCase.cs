using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using QR_Tool_Winform.Message;
using QR_Tool_Winform.Global;
using QR_Tool_Winform.DataBase;
using System.Data;
using QR_Tool_Winform.Certificate;

namespace QR_Tool_Winform
{
    class OnlineDeviceTestCase
    {



        public OnlineDeviceTestCase()
        {
  

        }

        public static bool RunTestCase(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage,string selectTestCaseName,ref string munualMessage)
        {
            bool runResult;
            munualMessage = Tools.GetTestCaseManualMessage(selectTestCaseName);
            switch (selectTestCaseName)
            {
                case "OLD_TABR001":           
                    runResult = OLD_TABR001(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR002":                
                    runResult = OLD_TABR002(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR003":             
                    runResult = OLD_TABR003(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR004":                    
                    runResult = OLD_TABR004(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR005":                    
                    runResult = OLD_TABR005(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR006":
                    runResult = OLD_TABR006(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR007":                  
                    runResult = OLD_TABR007(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TABR008":                    
                    runResult = OLD_TABR008(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ001":
                    runResult = OLD_TTSQ001(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ002":
                    runResult = OLD_TTSQ002(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ003":
                    runResult = OLD_TTSQ003(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ004":
                    runResult = OLD_TTSQ004(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ005":
                    runResult = OLD_TTSQ005(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ006":
                    runResult = OLD_TTSQ006(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ007":
                    runResult = OLD_TTSQ007(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ008":
                    runResult = OLD_TTSQ008(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ009":
                    runResult = OLD_TTSQ009(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                case "OLD_TTSQ010":
                    runResult = OLD_TTSQ010(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;
                 case "OLD_TTSQ011":
                    runResult = OLD_TTSQ011(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;

                case "OLD_TSCM001":
                case "OLD_TREF001":
                    runResult = OLD_TSCM001(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM002":
                case "OLD_TREF002":
                    runResult = OLD_TSCM002(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM003":
                case "OLD_TREF003":
                    runResult = OLD_TSCM003(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM004":
                case "OLD_TREF004":
                    runResult = OLD_TSCM004(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM005":
                case "OLD_TREF005":
                    runResult = OLD_TSCM005(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM006":
                case "OLD_TREF006":
                    runResult = OLD_TSCM006(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM007":
                case "OLD_TREF007":
                    runResult = OLD_TSCM007(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM008":
                case "OLD_TREF008":
                    runResult = OLD_TSCM008(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;
                case "OLD_TSCM009":
                case "OLD_TREF009":
                    runResult = OLD_TSCM009(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage, selectTestCaseName);
                    break;

                case "OLD_TSTA001":
                    munualMessage = "";
                    runResult = OLD_TSTA001(qrMessage, hlps, ref CaseTransNo, ref mw, ref errorMessage);
                    break;

                default:
                    runResult = false;
                    break;



            }
            return runResult;



        }
#region 申请二维码案例
        public static bool OLD_TABR001(QRMessage qrMessage,  HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {
          

            {

                bool Caseflag = true;
                errorMessage = "";
                string  messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    
                      res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20,""), "00", Tools.GetRespMsg("00"), "未完成", null,"", ref Caseflag, ref errorMessage);
                      mw.SetErrorText(errorMessage, Color.Red);
                      ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                      if (ResponseMessage != null)
                     {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
   
                     }
                    else
                     {
                                 mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                                 CaseTransNo--;
                                return false;
                      }
                 }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                          mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red); 
                           CaseTransNo--;
                           return false;
               }
                if (messageName == "APP消费")
                {
                    res_Dic = qrMessage.PackageResponseMessage_ReAPP_Sale("00", null, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                   
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName == "交易状态查询" )
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (res_Dic["origRespCode"].Equals("00"))
                   { 
                        CaseTransNo = 0;
                    }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR002(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    string cerPath = Application.StartupPath + "\\Certificate\\" + "TestCA.cer";
                    string signPubKeyCert = DataCertificate.GetCertificateString(cerPath);
                    set_Dic.Add("signPubKeyCert", signPubKeyCert);
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, ""), "00", "成功", "未完成", set_Dic,"", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;
                        

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
         

                return Caseflag;
            }
        }
        public static bool OLD_TABR003(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                 
       
                    string signature = "DYznmutp7II8PpBG1OBtobjACU5+juInv5y3LEGGw42CRbnAheJDW7fm8urLJnB06rr0rHdV7kvZJaByhWq5vIhZJRDpqFW6rZTyqj99uZ9JjK5RSG3lyp7Zm/siS0YqVBg64j18c5mrN45yBiztdCqej0btMG6TnnC8qlHAvBOSSj6a3KVO7ICkzyhxiSCggMDaRxL/BTXzakFt8ch1grxW3fD4ln2x0W9PbBB70gS5GITiSvMFwf+kM5juvQ8VOt+Yb2NYXx8Y4ylovsC4ku4/JC+SuuXObOzGDQgzFH/mHs4AaZBWrUC6ECml2b8TPCEenUi3mMHuaUqZ5gwK0w==";

                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, ""), "00", "成功", "未完成", null, signature, ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR004(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, ""), "00", "成功", "未完成", null,"", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    mw.SetErrorText(messageName + "不响应", Color.Blue);
                    CaseTransNo = 0;

                    
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR005(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {


                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, ""), "11", Tools.GetRespMsg("11"), "未完成", null, "",ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR006(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
          

                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, ""), "00", Tools.GetRespMsg("00"), "未完成", null,"", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 400, Parameters.MessageEncode.encValue);
                        mw.SetErrorText( "http状态字返回400", Color.Blue);
                        CaseTransNo = 0;


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR007(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {

                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(TestConfig.MacQRCode, "number"), "00", Tools.GetRespMsg("00"), "未完成", null, "",ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "APP消费")
                {
                    res_Dic = qrMessage.PackageResponseMessage_ReAPP_Sale("00", null, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);

                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName == "交易状态查询")
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (res_Dic["origRespCode"].Equals("00"))
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }


                return Caseflag;
            }
        }
        public static bool OLD_TABR008(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {

                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(TestConfig.MacQRCode, "letter"), "00", Tools.GetRespMsg("00"), "未完成", null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "APP消费")
                {
                    res_Dic = qrMessage.PackageResponseMessage_ReAPP_Sale("00", null, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);

                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName == "交易状态查询")
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (res_Dic["origRespCode"].Equals("00"))
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }


                return Caseflag;
            }
        }
        #endregion



#region 交易状态查询
        public static bool OLD_TTSQ001(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null,"", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;



                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ002(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "",ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }         
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    if (CaseTransNo == 2)
                    {
                        string cerPath = Application.StartupPath + "\\Certificate\\" + "TestCA.cer";
                        string signPubKeyCert = DataCertificate.GetCertificateString(cerPath);
                        set_Dic.Add("signPubKeyCert", signPubKeyCert);
                    }
                    else
                    {
                        set_Dic = null;
                    }
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic,"" ,ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                      
                            CaseTransNo = 0;
                        

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2 )
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
               

                return Caseflag;
            }
        }
        public static bool OLD_TTSQ003(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" &&CaseTransNo == 2 )
                {
                    string signature = "";
                    if (CaseTransNo == 2)
                    {
                      signature = "DYznmutp7II8PpBG1OBtobjACU5+juInv5y3LEGGw42CRbnAheJDW7fm8urLJnB06rr0rHdV7kvZJaByhWq5vIhZJRDpqFW6rZTyqj99uZ9JjK5RSG3lyp7Zm/siS0YqVBg64j18c5mrN45yBiztdCqej0btMG6TnnC8qlHAvBOSSj6a3KVO7ICkzyhxiSCggMDaRxL/BTXzakFt8ch1grxW3fD4ln2x0W9PbBB70gS5GITiSvMFwf+kM5juvQ8VOt+Yb2NYXx8Y4ylovsC4ku4/JC+SuuXObOzGDQgzFH/mHs4AaZBWrUC6ECml2b8TPCEenUi3mMHuaUqZ5gwK0w==";
                    }

                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        
                            CaseTransNo = 0;
                        

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ004(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    string signature = "";
               
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        if (CaseTransNo == 2)
                        {
                            mw.SetErrorText(messageName + "不响应", Color.Blue);
                        }
                        else
                        {

                            qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                            bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                            CaseTransNo = 0;
                        }
           

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ005(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    string signature = "";
                    string respCode = "00";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    if (CaseTransNo == 2)
                    {
                        respCode = "34";
                        string origRespCode = "00";
                        set_Dic.Add("origRespCode", origRespCode);
                        set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    }
                    else
                    {
                        set_Dic = null;
                    }

                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query(respCode, Tools.GetRespMsg(respCode), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 3)
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ006(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2 )
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    string origRespCode = "00";
                    set_Dic.Add("origRespCode", origRespCode);
                    set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("01", Tools.GetRespMsg("01"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                      

                            qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                            bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                            CaseTransNo = 0;
                        


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ007(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    if (CaseTransNo == 2)
                    {
                        string origRespCode = "03";
                        set_Dic.Add("origRespCode", origRespCode);
                        set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    }
                    else
                    {
                        set_Dic = null;
                    }
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 3)
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ008(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    if (CaseTransNo == 2)
                    {
                        string origRespCode = "04";
                        set_Dic.Add("origRespCode", origRespCode);
                        set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    }
                    else
                    {
                        set_Dic = null;
                    }
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 3)
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ009(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    if (CaseTransNo == 2)
                    {
                        string origRespCode = "05";
                        set_Dic.Add("origRespCode", origRespCode);
                        set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    }
                    else
                    {
                        set_Dic = null;
                    }
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 3)
                        {
                            CaseTransNo = 0;
                        }

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 3))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ010(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
               
                    string origRespCode = "01";
                   set_Dic.Add("origRespCode", origRespCode);
                    set_Dic.Add("origRespMsg", Tools.GetRespMsg(origRespCode));
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                   
                            CaseTransNo = 0;
                  

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2 )
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TTSQ011(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    string signature = "";
                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), set_Dic, signature, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 400, Parameters.MessageEncode.encValue);
                        mw.SetErrorText(messageName+":" + "http状态字响应400", Color.Blue);

                        CaseTransNo = 0;


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }


        #endregion


        #region 消费撤销
        public static bool OLD_TSCM001(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                string judgeName = "";
                bool Caseflag = true;
                errorMessage = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {

                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation("00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund("00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                     

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2 )
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM002(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if(selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if(selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }
                
                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {

                    Dictionary<string, string> set_Dic = new Dictionary<string, string>();
                    string cerPath = Application.StartupPath + "\\Certificate\\" + "TestCA.cer";
                    string signPubKeyCert = DataCertificate.GetCertificateString(cerPath);
                    set_Dic.Add("signPubKeyCert", signPubKeyCert);
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation("00", Tools.GetRespMsg("00"), "完成", set_Dic, "", ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund("00", Tools.GetRespMsg("00"), "完成", set_Dic, "", ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM003(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "DYznmutp7II8PpBG1OBtobjACU5+juInv5y3LEGGw42CRbnAheJDW7fm8urLJnB06rr0rHdV7kvZJaByhWq5vIhZJRDpqFW6rZTyqj99uZ9JjK5RSG3lyp7Zm/siS0YqVBg64j18c5mrN45yBiztdCqej0btMG6TnnC8qlHAvBOSSj6a3KVO7ICkzyhxiSCggMDaRxL/BTXzakFt8ch1grxW3fD4ln2x0W9PbBB70gS5GITiSvMFwf+kM5juvQ8VOt+Yb2NYXx8Y4ylovsC4ku4/JC+SuuXObOzGDQgzFH/mHs4AaZBWrUC6ECml2b8TPCEenUi3mMHuaUqZ5gwK0w==";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation("00", Tools.GetRespMsg("00"), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund("00", Tools.GetRespMsg("00"), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM004(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation("00", Tools.GetRespMsg("00"), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund("00", Tools.GetRespMsg("00"), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    mw.SetErrorText(messageName + "不响应", Color.Blue);
                    CaseTransNo = 0;
                }

                
               if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM005(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    string respCode = "01";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        CaseTransNo = 0;

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2)
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM006(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    string respCode = "03";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                    

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2|| CaseTransNo == 4))
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if(CaseTransNo==4)
                        {

                            CaseTransNo = 0;
                        }


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 4))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM007(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    string respCode = "04";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 4))
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 4)
                        {

                            CaseTransNo = 0;
                        }


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 4))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM008(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    string respCode = "05";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 4))
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        if (CaseTransNo == 4)
                        {

                            CaseTransNo = 0;
                        }


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && (CaseTransNo == 2 || CaseTransNo == 4))
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }
        public static bool OLD_TSCM009(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage, string selectTestCaseName)
        {


            {
                string selectType = "";
                bool Caseflag = true;
                errorMessage = "";
                string judgeName = "";
                selectType = selectTestCaseName.Substring(0, 8);
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (selectType.Equals("OLD_TSCM"))
                {
                    judgeName = "消费撤销";
                }
                if (selectType.Equals("OLD_TREF"))
                {
                    judgeName = "退货";
                }

                if (messageName == "申请二维码" && CaseTransNo == 1)
                {
                    Parameters.phoneToggle = false;
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(20, ""), "00", Tools.GetRespMsg("00"), "完成", null, "", ref Caseflag, ref errorMessage);
                    Parameters.phoneToggle = true;
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "申请二维码" && CaseTransNo == 1)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == judgeName && CaseTransNo == 3)
                {
                    string signature = "";
                    string respCode = "00";
                    if (judgeName.Equals("消费撤销"))
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Consumption_Revocation(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    else
                    {
                        res_Dic = qrMessage.PackageResponseMessage_Refund(respCode, Tools.GetRespMsg(respCode), "完成", null, signature, ref Caseflag, ref errorMessage);
                    }
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 400, Parameters.MessageEncode.encValue);
                        mw.SetErrorText(messageName+"Http状态字响应400", Color.Blue);
                        CaseTransNo = 0;


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != judgeName && CaseTransNo == 3)
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }
                if (messageName == "交易状态查询" && CaseTransNo == 2 )
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null, "", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                        //if (CaseTransNo == 4)
                        //{

                        //    CaseTransNo = 0;
                        //}


                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName != "交易状态查询" && CaseTransNo == 2 )
                {
                    mw.SetErrorText("未按案例规定流程进行，此笔交易为" + messageName, Color.Red);
                    CaseTransNo--;
                    return false;
                }


                return Caseflag;
            }
        }

        #endregion

        #region 稳定性测试
        public static bool OLD_TSTA001(QRMessage qrMessage, HttpListenerResponse hlps, ref int CaseTransNo, ref MainWindow mw, ref string errorMessage)
        {


            {

                bool Caseflag = true;
                errorMessage = "";
                string messageName = qrMessage.GetMessageName();
                Encoding req_enconde = qrMessage.GetMessageEncoding();
                qrMessage.ShowRequestMessage(ref errorMessage, ref mw, CaseTransNo);
                mw.SetErrorText(errorMessage, Color.Red);
                //响应报文
                string ResponseMessage = null;
                Dictionary<string, string> res_Dic = null;
                if (messageName == "申请二维码")
                {
                
                    res_Dic = qrMessage.PackageResponseMessage_Apply_BarCode(Tools.GenerateRandomNumber(10, "number"), "00", "成功", "未完成", null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
              
                if (messageName == "APP消费")
                {
                    res_Dic = qrMessage.PackageResponseMessage_ReAPP_Sale("00", null, ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);

                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Encoding.GetEncoding("GBK"));
                        DataTable dt = Log.GetDictionaryTable("StableLog");
                        int count = dt.Rows.Count;
                        mw.SetQRCount(count.ToString());
                        if (count == 300)
                        {
                            bool isValidateCorret = true;
                            foreach (DataRow row in dt.Rows)
                            {
                                string validateResult = (string)row["validateResult"]; //也可以使用row["id"] 获取这一列的值；
                                if(validateResult.Equals("错误"))
                                {
                                    isValidateCorret = false;
                                    mw.SetErrorText("ID="+row["ID"].ToString()+",二维码错误", Color.Blue);
                                }


                            }
                            if (isValidateCorret == true)
                            {
                                CaseTransNo = 0;
                            }
                            else
                            {

                                return false;
                            }
                        }
                        

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }
                if (messageName == "交易状态查询")
                {
                    res_Dic = qrMessage.PackageResponseMessage_Transaction_Status_Query("00", Tools.GetRespMsg("00"), "05", Tools.GetRespMsg("05"), null,"", ref Caseflag, ref errorMessage);
                    mw.SetErrorText(errorMessage, Color.Red);
                    ResponseMessage = UP_SDK.SDKUtil.CreateLinkString(res_Dic, true, false, req_enconde);
                    if (ResponseMessage != null)
                    {
                        qrMessage.ShowResponseMessage(ref mw, CaseTransNo, res_Dic, ref errorMessage);
                        bool sendFlag = qrMessage.SendMessage(ref mw, ResponseMessage, hlps, 200, Parameters.MessageEncode.encValue);
                    

                    }
                    else
                    {
                        mw.SetErrorText(messageName + "不响应，原因：未能组成正确响应报文。", Color.Red);
                        CaseTransNo--;
                        return false;
                    }
                }


                return Caseflag;
            }
        }
#endregion


    }
}
