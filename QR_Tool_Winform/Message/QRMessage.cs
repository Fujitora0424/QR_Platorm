using QR_Tool_Winform.Certificate;
using QR_Tool_Winform.Tcp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QR_Tool_Winform.Global;
using System.Data;

namespace QR_Tool_Winform.Message
{
    class QRMessage
    {
        Dictionary<string, string> mes_Dic;
        private string messageType = "";
        private string messageSubType = "";
        private string messageName = "";
        private string messageEncoding = "";
        private Encoding encode = null;

        public QRMessage(Dictionary<string, string> re_Dic) 
       {
            mes_Dic = re_Dic;
            messageType = mes_Dic["txnType"];
            messageSubType = mes_Dic["txnSubType"];
            messageEncoding = mes_Dic["encoding"];
              #region   交易类型判断
            if (messageType.Equals("01")&&messageSubType.Equals("07"))
             {

                messageName = "申请二维码";

            }
            else if (messageType.Equals("99"))
            {

                messageName = "APP消费";

            }
            else if (messageType.Equals("00"))
            {

                messageName = "交易状态查询";

            }
            else if (messageType.Equals("31") && messageSubType.Equals("00"))
            {

                messageName = "消费撤销";

            }
            else if (messageType.Equals("04")&&messageSubType.Equals("00"))
            {

                messageName = "退货";

            }
            else 
            {

                messageName = "未知交易类型";

            }
            #endregion
            if (messageEncoding.Equals("GBK"))
            {

                encode = Encoding.GetEncoding("GBK");
            }
            else
            {
                encode = Encoding.UTF8;
            }


        }

        public string GetMessageName()
        {

            return messageName;
        } //获取交易名称
        public Encoding GetMessageEncoding()
        {

            return encode;

            
        }//获取编码类型
        public Dictionary<string, string> GetRecMessage()
        {
            Dictionary<string, string> new_Dic = new Dictionary<string, string>(mes_Dic);
            return new_Dic;

        }
        public Dictionary<string, string> PackageResponseMessage_Apply_BarCode(string qrCode, string respCode, string respMsg, string messageResult, Dictionary<string, string> setre_Dic, string signature,ref bool isCorrect, ref string errorMessage)
        {
            try
            {
                string resultCheck = CheckMessage();
                if (!resultCheck.Equals(""))
                {
                    errorMessage += resultCheck;
                    isCorrect = false;
                 }
                Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                Dictionary<string, object> log_Dic = new Dictionary<string, object>();
                string accessType = Field.AccessType;
                string bizType = Field.BizType;
                string encoding = Field.Encoding;
                string merId = Field.MerId;
                string orderId = "";
                string txnSubType = "";
                string txnTime = "";
                string txnType = "";
                string version = Field.Version;
                string txnAmt = "";
                string signMethod = Field.SignMethod;
                string signPubKeyCert = Field.SignPubKeyCert;
                //string queryId = "";//唯一流水号 
                string traceNo = "";
                string backUrl = "";




                //组包
                //值等于请求

                accessType = mes_Dic.ContainsKey("accessType") ? mes_Dic["accessType"] : accessType;
                res_Dic.Add("accessType", accessType);
                encoding = mes_Dic.ContainsKey("encoding")? mes_Dic["encoding"] : encoding;
                res_Dic.Add("encoding", encoding);
                orderId = mes_Dic.ContainsKey("orderId") ? mes_Dic["orderId"] : "";
                res_Dic.Add("orderId", orderId);
                merId = mes_Dic.ContainsKey("merId") ? mes_Dic["merId"] : merId;
                res_Dic.Add("merId", merId);
                txnTime = mes_Dic.ContainsKey("txnTime")? mes_Dic["txnTime"] : "";
                res_Dic.Add("txnTime", txnTime);
                txnSubType = mes_Dic.ContainsKey("txnSubType") ? mes_Dic["txnSubType"] : "";
                res_Dic.Add("txnSubType",txnSubType);    
                txnType = mes_Dic.ContainsKey("txnType") ? mes_Dic["txnType"] : "";
                res_Dic.Add("txnType",txnType);
                txnAmt = mes_Dic.ContainsKey("txnAmt") ? mes_Dic["txnAmt"] : "";
                res_Dic.Add("txnAmt", txnType);
                //固定值
                res_Dic.Add("bizType", bizType);
                res_Dic.Add("version", version);
                res_Dic.Add("signMethod", signMethod);
                //参数值
                res_Dic.Add("qrCode", qrCode);
                res_Dic.Add("respCode", respCode);
                res_Dic.Add("respMsg", respMsg);

                //获取证书            
               res_Dic.Add("signPubKeyCert", signPubKeyCert);
                if (setre_Dic != null)// 设置返回值
                {
                    foreach (var v in setre_Dic)
                    {
                        if (res_Dic.ContainsKey(v.Key))
                        {

                            res_Dic[v.Key] = v.Value;
                        }
                    }

                }
                //计算签名
                Encrypt.SignByCertInfo(res_Dic, encode, ref errorMessage);

                if (respCode.Equals("00"))
                {

                    int value = new Random().Next(100000, 999999);
                    traceNo = value.ToString();//生成tranceNo
                    //记录日志
                    log_Dic.Add("queryId", txnTime + traceNo + "8");
                    log_Dic.Add("messageName", messageName);
                    log_Dic.Add("traceNo", traceNo);
                    log_Dic.Add("orderId", orderId);
                    log_Dic.Add("txnType", txnType);
                    log_Dic.Add("txnSubType", txnSubType);
                    log_Dic.Add("txnTime", txnTime);
                    log_Dic.Add("txnAmt", txnAmt);
                    log_Dic.Add("messageResult", messageResult);
                    log_Dic.Add("qrCode", qrCode);
                    if (mes_Dic.ContainsKey(backUrl))
                    {

                        backUrl = mes_Dic["backUrl"];
                    }
                    log_Dic.Add("backUrl", backUrl);
                    DataBase.Log.InsertLog(log_Dic, ref errorMessage);

                    if (Parameters.phoneToggle)//启动扫码
                    {
                        PhoneControl.PhoneControl.StartScanBarCode(log_Dic, encoding);
                    }
                  
                }
              

                if (!signature.Equals(""))// 设置返回值
                {

                    res_Dic["signature"] = signature;

                }

                res_Dic = res_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
                return res_Dic;

            }

            catch(Exception e)
            {

                errorMessage = e.Message;
                return null;

            }















        }
        public Dictionary<string, string> PackageResponseMessage_Transaction_Status_Query( string respCode, string respMsg,string origRespCode,string origRespMsg, Dictionary<string, string> setre_Dic,string signature, ref bool isCorrect,ref string errorMessage)
        {
            try
            {
                string resultCheck = CheckMessage();
                if (!resultCheck.Equals(""))
                {
                    errorMessage += resultCheck;
                    isCorrect = false;
                }
                Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                Dictionary<string, object> org_Dic = new Dictionary<string, object>();
                string accessType = "";
                string bizType = Field.BizType;
                string encoding = Field.Encoding;
                string merId = Field.MerId;
                string orderId = "";
                string txnTime = "";
                string version = Field.Version;
                string signPubKeyCert = Field.SignPubKeyCert;
                string settleCurrencyCode = Field.CurrencyCode;
                string traceTime = "";
                string settleDate = "";
                string signMethod = Field.SignMethod;



                //获取原交易信息
                txnTime = mes_Dic.ContainsKey("txnTime") ? mes_Dic["txnTime"] : "";
                res_Dic.Add("txnTime", txnTime);
                DataBase.Log.GetorgLog(org_Dic, "", txnTime, "", ref errorMessage);
   

                //组包
                //同请求
                accessType = mes_Dic.ContainsKey("accessType")? mes_Dic["accessType"] : accessType;
                res_Dic.Add("accessType", accessType);
                encoding = mes_Dic.ContainsKey("encoding") ? mes_Dic["encoding"] : encoding;
                res_Dic.Add("encoding", encoding);
                orderId = mes_Dic.ContainsKey("orderId")? mes_Dic["orderId"] : "";
                res_Dic.Add("orderId", orderId);
                merId = mes_Dic.ContainsKey("merId") ? mes_Dic["merId"] : merId;
                res_Dic.Add("merId", merId);



                //固定值
                res_Dic.Add("bizType", bizType);
                res_Dic.Add("version", version);
                res_Dic.Add("signMethod", signMethod);


                //参数值

                res_Dic.Add("respCode", respCode);
                res_Dic.Add("respMsg", respMsg);
                if (respCode.Equals("00"))//非00不返回原交易信息
                {
                    if (org_Dic["messageResult"].Equals("完成"))
                    {
                        res_Dic.Add("origRespCode", "00");
                        res_Dic.Add("origRespMsg", "成功");
                        DateTime dt = DateTime.Now;
                        traceTime = dt.ToString("MMddHHmmss");
                        res_Dic.Add("traceTime", traceTime);
                        settleDate = traceTime.Substring(0, 4);
                        res_Dic.Add("settleDate", settleDate);
                        res_Dic.Add("settleCurrencyCode", settleCurrencyCode);
                        //获取原交易信息
                        res_Dic.Add("settleAmt", (string)org_Dic["txnAmt"]);
                        res_Dic.Add("traceNo", (string)org_Dic["traceNo"]);
                        res_Dic.Add("queryId", (string)org_Dic["queryId"]);
                    }
                    else
                    {
                        res_Dic.Add("origRespCode", origRespCode);
                        res_Dic.Add("origRespMsg", origRespMsg);
                        res_Dic.Add("settleAmt", "0");

                    }

                }
                else
                {
                    res_Dic.Add("origRespCode", origRespCode);
                    res_Dic.Add("origRespMsg", origRespMsg);
                    res_Dic.Add("settleAmt", (string)org_Dic["txnAmt"]);
                }
               

                //获取原交易交易类型
                res_Dic.Add("txnSubType", (string)org_Dic["txnSubType"]);
                res_Dic.Add("txnType", (string)org_Dic["txnType"]);

                //获取证书
     
                res_Dic.Add("signPubKeyCert", signPubKeyCert);
                if (setre_Dic != null)// 设置返回值
                {
                    foreach (var v in setre_Dic)
                    {
                        if (res_Dic.ContainsKey(v.Key))
                        {

                            res_Dic[v.Key] = v.Value;
                        }
                    }

                }
                //计算签名
                Encrypt.SignByCertInfo(res_Dic, encode, ref errorMessage);
           

                if (!signature.Equals(""))// 设置返回值
                {

                    res_Dic["signature"] = signature;

                }
                res_Dic = res_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);//sort顺序
                return res_Dic;

            }

            catch (Exception e)
            {
                errorMessage = e.Message;
                return null;

            }















        }
        public Dictionary<string, string> PackageResponseMessage_Consumption_Revocation(string respCode, string respMsg, string messageResult, Dictionary<string, string> setre_Dic,string signature, ref bool isCorrect, ref string errorMessage)
        {
            try
            {
                string resultCheck = CheckMessage();
                if (!resultCheck.Equals(""))
                {
                    errorMessage += resultCheck;
                    isCorrect = false;
                }
                Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                Dictionary<string, object> log_Dic = new Dictionary<string, object>();
                Dictionary<string, object> org_Dic = new Dictionary<string, object>();
                string accessType = Field.AccessType;
                string bizType = Field.BizType;
                string encoding = Field.Encoding;
                string merId = Field.MerId;
                string orderId = "";
                string txnSubType = "";
                string txnTime = "";
                string txnType = "";
                string version = Field.Version;
                string txnAmt = "";
                string signPubKeyCert = Field.SignPubKeyCert;
                string signMethod = Field.SignMethod;
                //string queryId = "";//唯一流水号 
                string traceNo = "";
                string origTxnTime = "";
                string origOrderId = "";
                string origQryId = "";





                if (mes_Dic.ContainsKey("origTxnTime") && mes_Dic.ContainsKey("origOrderId")) 
                {
                    origTxnTime = mes_Dic.ContainsKey("origTxnTime")? mes_Dic["origTxnTime"] : "";
                    origOrderId = mes_Dic.ContainsKey("origOrderId")? mes_Dic["origOrderId"] : "";

                    DataBase.Log.GetorgLog(org_Dic, "", origTxnTime, "", ref errorMessage);
        

                }
                else if(mes_Dic.ContainsKey("origQryId"))
                {
                    origQryId = mes_Dic.ContainsKey("origQryId")? mes_Dic["origQryId"] : "";
                    DataBase.Log.GetorgLog(org_Dic, "", "", origQryId, ref errorMessage);
                  

                }
                else
                {
                    errorMessage += "origQryId或origTxnTime+origOrderId均不存在";
                    isCorrect = false;

                }
                //愿交易信息返回
                res_Dic.Add("origTxnTime", (string)org_Dic["txnTime"]);
                res_Dic.Add("origOrderId", (string)org_Dic["orderId"]);
                res_Dic.Add("origQryId", (string)org_Dic["queryId"]);



                //组包
                //值等于请求

                accessType = mes_Dic.ContainsKey("accessType")? mes_Dic["accessType"] : accessType;
                res_Dic.Add("accessType", accessType);
                encoding = mes_Dic.ContainsKey("encoding") ? mes_Dic["encoding"] : encoding;
                res_Dic.Add("encoding", encoding);
                orderId = mes_Dic.ContainsKey("orderId") ? mes_Dic["orderId"] : "";
                res_Dic.Add("orderId", orderId);
                merId = mes_Dic.ContainsKey("merId") ? mes_Dic["merId"] : merId;
                res_Dic.Add("merId", merId);
                txnTime = mes_Dic.ContainsKey("txnTime") ? mes_Dic["txnTime"] : "";
                res_Dic.Add("txnTime", txnTime);
                txnSubType = mes_Dic.ContainsKey("txnSubType") ? mes_Dic["txnSubType"] : "";
                res_Dic.Add("txnSubType", txnSubType);
                txnType = mes_Dic.ContainsKey("txnType") ? mes_Dic["txnType"] : "";
                res_Dic.Add("txnType", txnType);
                signMethod = !mes_Dic.ContainsKey("signMethod") ? mes_Dic["signMethod"] : signMethod;
                res_Dic.Add("signMethod", signMethod);
                txnAmt = mes_Dic.ContainsKey("txnAmt") ? mes_Dic["txnAmt"] : "";
                if(!txnAmt.Equals((string)org_Dic["txnAmt"]))
                {
                    errorMessage += "txnAmt错误,应等于" + (string)org_Dic["txnAmt"];
                    isCorrect = false;
                }
                res_Dic.Add("txnAmt", txnAmt);

                //固定值
                res_Dic.Add("bizType", bizType);
                res_Dic.Add("version", version);
                //参数值
                res_Dic.Add("respCode", respCode);
                res_Dic.Add("respMsg", respMsg);
                //获取证书
                res_Dic.Add("signPubKeyCert", signPubKeyCert);
                if (setre_Dic != null)// 设置返回值
                {
                    foreach (var v in setre_Dic)
                    {
                        if (res_Dic.ContainsKey(v.Key))
                        {

                            res_Dic[v.Key] = v.Value;
                        }
                    }

                }
                //计算签名
                Encrypt.SignByCertInfo(res_Dic, encode, ref errorMessage);
                //记录日志
         

                if (respCode.Equals("00")|| respCode.Equals("03")|| respCode.Equals("04")|| respCode.Equals("05"))
                {

                    int value = new Random().Next(100000, 999999);
                    traceNo = value.ToString();
                    log_Dic.Add("queryId", txnTime + traceNo + "8");
                    log_Dic.Add("messageName", messageName);
                    log_Dic.Add("traceNo", traceNo);
                    log_Dic.Add("orderId", orderId);
                    log_Dic.Add("txnType", txnType);
                    log_Dic.Add("txnSubType", txnSubType);
                    log_Dic.Add("txnTime", txnTime);
                    log_Dic.Add("txnAmt", txnAmt);
                    log_Dic.Add("messageResult", messageResult);
                    DataBase.Log.InsertLog(log_Dic, ref errorMessage);
                }
            
                if (!signature.Equals(""))// 设置返回值
                {

                    res_Dic["signature"] = signature;

                }
                res_Dic = res_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
                return res_Dic;

            }

            catch (Exception e)
            {
                errorMessage = e.Message;
                return null;

            }















        }
        public Dictionary<string, string> PackageResponseMessage_Refund(string respCode, string respMsg, string messageResult, Dictionary<string, string> setre_Dic, string signature, ref bool isCorrect, ref string errorMessage)
        {
            try
            {
                string resultCheck = CheckMessage();
                if (!resultCheck.Equals(""))
                {
                    errorMessage += resultCheck;
                    isCorrect = false;
                }
                Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                Dictionary<string, object> log_Dic = new Dictionary<string, object>();
                Dictionary<string, object> org_Dic = new Dictionary<string, object>();
                string accessType = Field.AccessType;
                string bizType = Field.BizType;
                string encoding = Field.Encoding;
                string merId =Field.MerId;
                string orderId = "";
                string txnSubType = "";
                string txnTime = "";
                string txnType = "";
                string version = Field.Version;
                string txnAmt = "";
                string signPubKeyCert = Field.SignPubKeyCert;
                string signMethod = Field.SignMethod;
                //string queryId = "";//唯一流水号 
                string traceNo = "";
                string origTxnTime = "";
                string origOrderId = "";
                string origQryId = "";





                if (mes_Dic.ContainsKey("origTxnTime") && mes_Dic.ContainsKey("origOrderId"))
                {
                    origTxnTime = !mes_Dic["origTxnTime"].Equals("") ? mes_Dic["origTxnTime"] : "";
                    origOrderId = !mes_Dic["origOrderId"].Equals("") ? mes_Dic["origOrderId"] : "";
                    DataBase.Log.GetorgLog(org_Dic, "", origTxnTime, "", ref errorMessage);


                }
                else if (mes_Dic.ContainsKey("origQryId"))
                {
                    origQryId = mes_Dic.ContainsKey("origQryId") ? mes_Dic["origQryId"] : "";
                    DataBase.Log.GetorgLog(org_Dic, "", "", origQryId, ref errorMessage);


                }
                else
                {
                    errorMessage += "origQryId或origTxnTime+origOrderId均不存在";
                    isCorrect = false;

                }
                //愿交易信息返回
                res_Dic.Add("origTxnTime", (string)org_Dic["txnTime"]);
                res_Dic.Add("origOrderId", (string)org_Dic["orderId"]);
                res_Dic.Add("origQryId", (string)org_Dic["queryId"]);



                //组包
                accessType = mes_Dic.ContainsKey("accessType") ? mes_Dic["accessType"] : accessType;
                res_Dic.Add("accessType", accessType);
                encoding = mes_Dic.ContainsKey("encoding") ? mes_Dic["encoding"] : encoding;
                res_Dic.Add("encoding", encoding);
                orderId = mes_Dic.ContainsKey("orderId") ? mes_Dic["orderId"] : "";
                res_Dic.Add("orderId", orderId);
                merId = mes_Dic.ContainsKey("merId") ? mes_Dic["merId"] : merId;
                res_Dic.Add("merId", merId);
                txnTime = mes_Dic.ContainsKey("txnTime") ? mes_Dic["txnTime"] : "";
                res_Dic.Add("txnTime", txnTime);
                txnSubType = mes_Dic.ContainsKey("txnSubType") ? mes_Dic["txnSubType"] : "";
                res_Dic.Add("txnSubType", txnSubType);
                txnType = mes_Dic.ContainsKey("txnType") ? mes_Dic["txnType"] : "";
                res_Dic.Add("txnType", txnType);
                signMethod = !mes_Dic.ContainsKey("signMethod") ? mes_Dic["signMethod"] : signMethod;
                res_Dic.Add("signMethod", signMethod);
                txnAmt = mes_Dic.ContainsKey("txnAmt") ? mes_Dic["txnAmt"] : "";
                if (float.Parse(txnAmt) > float.Parse((string)org_Dic["txnAmt"]))
                {
                    errorMessage += "txnAmt错误,应小于等于" + (string)org_Dic["txnAmt"];
                    isCorrect = false;
                }
                res_Dic.Add("txnAmt", txnAmt);

                //固定值
                res_Dic.Add("bizType", bizType);
                res_Dic.Add("version", version);
                //参数值
                res_Dic.Add("respCode", respCode);
                res_Dic.Add("respMsg", respMsg);
                //获取证书
              
                res_Dic.Add("signPubKeyCert", signPubKeyCert);
                //计算签名
                if (setre_Dic != null)// 设置返回值
                {
                    foreach (var v in setre_Dic)
                    {
                        if (res_Dic.ContainsKey(v.Key))
                        {

                            res_Dic[v.Key] = v.Value;
                        }
                    }

                }
                Encrypt.SignByCertInfo(res_Dic, encode, ref errorMessage);
                

                if (respCode.Equals("00") || respCode.Equals("03") || respCode.Equals("04") || respCode.Equals("05"))
                {

                    int value = new Random().Next(100000, 999999);
                    traceNo = value.ToString();
                    log_Dic.Add("queryId", txnTime + traceNo + "8");
                    log_Dic.Add("messageName", messageName);
                    log_Dic.Add("traceNo", traceNo);
                    log_Dic.Add("orderId", orderId);
                    log_Dic.Add("txnType", txnType);
                    log_Dic.Add("txnSubType", txnSubType);
                    log_Dic.Add("txnTime", txnTime);
                    log_Dic.Add("txnAmt", txnAmt);
                    log_Dic.Add("messageResult", messageResult);
                    DataBase.Log.InsertLog(log_Dic, ref errorMessage);
                }
                if (!signature.Equals(""))// 设置返回值
                {

                    res_Dic["signature"] = signature;

                }
                res_Dic = res_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
                return res_Dic;

            }

            catch (Exception e)
            {
                errorMessage = e.Message;
                return null;

            }















        }
        public Dictionary<string, string> PackageResponseMessage_ReAPP_Sale( string respCode, Dictionary<string, string> setre_Dic, ref bool isCorrect, ref string errorMessage)
        {
            try
            {
               
                Dictionary<string, string> res_Dic = new Dictionary<string, string>();
                Dictionary<string, object> org_Dic = new Dictionary<string, object>();
                Dictionary<string,object> log_DIC = new Dictionary<string, object>();
                string encoding = "";
                //string orderId = "";
                //string txnSubType = "";
                //string txnTime = "";
                //string txnType = "";
                //string txnAmt = "";
                string queryId = "";//唯一流水号 
                //string traceNo = "";
                //string qrCode = "";

                queryId = !mes_Dic["queryId"].Equals("") ? mes_Dic["queryId"] : "";
                Dictionary<string, object> update_Dic = new Dictionary<string, object>();
                update_Dic.Add("messageResult", "完成");
                DataBase.Log.updataMessageResult(update_Dic, queryId, ref errorMessage);
                queryId = !mes_Dic["queryId"].Equals("") ? mes_Dic["queryId"] : "";
                DataBase.Log.GetorgLog(org_Dic, "", "", queryId, ref errorMessage);
                //组包
                encoding = !mes_Dic["encoding"].Equals("") ? mes_Dic["encoding"] : "";
                res_Dic.Add("encoding", encoding);
                res_Dic.Add("respCode", respCode);
                 
                if(!(org_Dic["qrCode"].Equals(mes_Dic["qrCode"])))
                {
                    errorMessage += "二维码错误,应为="+ org_Dic["qrCode"];
                    isCorrect = false;
                    log_DIC.Add("validateResult", "错误");

                }
                else
                {
                    log_DIC.Add("validateResult", "正确");

                }

                if(TestConfig.StableTest)
                {
                    log_DIC.Add("qrCode", (mes_Dic["qrCode"]));
                    log_DIC.Add("queryId", queryId);
                    DataBase.Log.InsertLog(log_DIC, "StableLog", "Log");

                }
                if (setre_Dic != null)// 设置返回值
                {
                    foreach (var v in setre_Dic)
                    {
                        if (res_Dic.ContainsKey(v.Key))
                        {

                            res_Dic[v.Key] = v.Value;
                        }
                    }

                }

                res_Dic = res_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
                return res_Dic;

            }

            catch (Exception e)
            {
          
                errorMessage = e.Message;
                return null;

            }

        }     
        public void ShowRequestMessage(ref string errorMessage, ref MainWindow mw, int caseTransNo)
        {
            string tabPageName = "";
            string SelectCaseName = MainWindow.SelectCaseName;
            int CaseTransNo = caseTransNo;
            int CaseState = MainWindow.CaseState;
            string LOGSave = "";
            MetroFramework.Controls.MetroGrid Gr_R = mw.CreateNewPageGird(mw.ReceiveText);
            mes_Dic = mes_Dic.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("keyName");
            DataColumn dc2 = new DataColumn("Key");
            DataColumn dc3 = new DataColumn("Value");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            foreach (var item in mes_Dic)
            {
                string selectcomand = string.Format("DataIdentification = '{0}'", item.Key);
                DataRow[] dr = Parameters.dtDictionnary.Select(selectcomand);
                if (dr.Length!=0)
                {
                    var name = dr[0][0];
                    dt.Rows.Add(name, item.Key, item.Value);
                }
                else
                {
                    var name = "未知key";
                   dt.Rows.Add(name, item.Key, item.Value);
                    errorMessage += "存在未知key:" + item.Key;

                }
            }
            mw.SetQRReceiveTextGird(Gr_R, dt);
            tabPageName = CaseTransNo.ToString().Trim() + "." + messageName;
            LOGSave += Tools.DataTableToString(dt);

            mw.SetPageName(tabPageName, mw.ReceiveText);
            if (Project.ProjectPath.Trim() != "" && SelectCaseName.Trim() != ""&& CaseState == 1)
            {
                StreamWriter sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", true);
                sw.Write(tabPageName + "请求报文\r\n" + LOGSave);
                sw.Close();
            }
            //else if (SelectCaseName.Trim() != "" && CaseState == 1)
            //{
            //    CaseState = 1;
            //    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "Log" + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", false);
            //    sw.Write(tabPageName + "请求报文\r\n" + LOGSave);
            //    sw.Close();

            //}
            else
            {
                Trace.SaveDefaultTrace(tabPageName + "请求报文\r\n" + LOGSave, 1,"");
         

            }

        }
        public void ShowResponseMessage( ref MainWindow mw, int caseTransNo,Dictionary<string,string> res_Dic, ref string errorMessage)
        {
            
            string tabPageName = "";
            string SelectCaseName = MainWindow.SelectCaseName;
            int CaseTransNo = caseTransNo;
            int CaseState = MainWindow.CaseState;
            MetroFramework.Controls.MetroGrid Gr_S = mw.CreateNewPageGird(mw.SendText);
            string LOGSave = "";
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("KeyName");
            DataColumn dc2 = new DataColumn("key");
            DataColumn dc3 = new DataColumn("Value");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            foreach (var item in res_Dic)
            {
                string selectcomand = string.Format("DataIdentification = '{0}'", item.Key);
                DataRow[] dr = Parameters.dtDictionnary.Select(selectcomand);
                var name = dr[0][0];
                dt.Rows.Add(name, item.Key, item.Value);
            }

            mw.SetQRSendTextGird(Gr_S, dt);
            tabPageName = CaseTransNo.ToString().Trim() + "." + messageName;
            LOGSave += Tools.DataTableToString(dt);
            mw.SetPageName(tabPageName, mw.SendText);
            if (Project.ProjectPath.Trim() != "" && SelectCaseName.Trim() != "" && CaseState == 1)
            {
                StreamWriter sw = new StreamWriter(Project.ProjectPath.Trim() + "\\" + Project.ProjectName.Trim() + "\\" + SelectCaseName.Trim() + ".txt", true);
                sw.Write(tabPageName + "应答报文\r\n" + LOGSave);
                sw.Close();
            }
         

            else
            {
                Trace.SaveDefaultTrace(tabPageName + "应答报文\r\n" + LOGSave, 1,"");

            }

        }      
        public bool SendMessage(ref MainWindow mw,string resopnseMessage, HttpListenerResponse response,int statusCode,Encoding resEncode)
        {
            try
            { 
                response.ContentEncoding = resEncode;//返回编码类型
                response.StatusCode = statusCode;//设置返回值
                byte[] buffer = resEncode.GetBytes(resopnseMessage);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length); //服务端发送回消息给客户端
                output.Close();
                return true;
            }
            catch
            {

                return false;


            }
        }
        public string CheckMessage()
        {

            string errorMessage = "";

            if (mes_Dic.ContainsKey("bizType"))
            {
                if (!mes_Dic["bizType"].Equals(Field.BizType))
                {
                    errorMessage += "bizType错误,应等于" + Field.BizType + "\r\n";

                }

            }
            else
            {
                errorMessage += "bizType不存在" + "\r\n";

            }
            if (mes_Dic.ContainsKey("certId"))
            {
                if (!mes_Dic["certId"].Equals(Field.CertId.Trim()))
                {
                    errorMessage += "certId错误,应等于" + Field.CertId+ "\r\n";

                }

            }
            else
            {
                errorMessage += "certId不存在" + "\r\n";

            }
            if (mes_Dic.ContainsKey("version"))
            {
                if (!mes_Dic["version"].Equals(Field.Version))
                {
                    errorMessage += "version错误,应等于" + Field.Version + "\r\n";

                }

            }
            else
            {
                errorMessage += "version不存在"  + "\r\n";

            }
            if (mes_Dic.ContainsKey("encoding"))
            {
                if (!mes_Dic["encoding"].Equals(Field.Encoding))
                {
                    errorMessage += "encoding错误,应等于" + Field.Encoding + "\r\n";

                }

            }
            else
            {
                errorMessage += "encoding不存在" + "\r\n";

            }
           

            if (mes_Dic.ContainsKey("merId"))
            {
                if (!mes_Dic["merId"].Equals(Field.MerId))
                {
                    errorMessage += "merId错误,应等于" + Field.MerId + "\r\n";

                }

            }
            else
            {
                errorMessage += "merId不存在" + "\r\n";

            }


            if (!messageName.Equals("交易状态查询"))
            {
               

                if (mes_Dic.ContainsKey("channelType"))
                {
                    if (!mes_Dic["channelType"].Equals(Field.ChannelType))
                    {
                        errorMessage += "channelType错误,应等于" + Field.ChannelType + "\r\n";

                    }

                }
                else
                {
                    errorMessage += "channelType不存在" + "\r\n";

                }

                if (mes_Dic.ContainsKey("backUrl"))
                {
                    if (!mes_Dic["backUrl"].ToLower().Equals(Field.BackUrl))
                    {
                        errorMessage += "backUrl错误,应等于" + Field.BackUrl + "\r\n";

                    }

                }
                else
                {
                    errorMessage += "backUrl不存在" + "\r\n";

                }

            }


            if (messageName.Equals("申请二维码"))
            {
                if (mes_Dic.ContainsKey("currencyCode"))
                {
                    if (!mes_Dic["currencyCode"].Equals(Field.CurrencyCode))
                    {
                        errorMessage += "currencyCode错误,应等于" + Field.CurrencyCode + "\r\n";

                    }

                }
                else
                {
                    errorMessage += "currencyCode不存在" + "\r\n";

                }
            }

            if (!messageName.Equals("APP消费"))
            {
                CheckQRMessage.ValidateSign(mes_Dic,  encode, ref errorMessage);//验证签名               
            }


            return errorMessage;
        }
    }
}
