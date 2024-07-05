﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HIS.Desktop.Common.BankQrCode
{
    public delegate void DelegateSendMessage(bool IsSuccess, string Message);
    public enum SendType
    {
        QR,
        Text
    }
    public class PosProcessor : SerialPort
    {
        private const int QR_LENGTH = 28;
        private const int A_LENGTH = 17;
        private const string QR_FORMAT = "\"C\":\"03\",\"A\":\"0.01\",\"D\":\"{0}\"";
        private const string A_FORMAT = "\"C\":\"04\",\"T\":\"{0}\"";
        private const string RESULT_FORMAT = "{\"C\":\"03\",\"R\":\"00\"}ED";
        public SendType typeSend = SendType.QR;
        private string MessageError = null;
        private DelegateSendMessage delegateSend;
        public PosProcessor(string portName, DelegateSendMessage delegateSend)
        {
            this.delegateSend = delegateSend;
            this.PortName = portName;
            this.DtrEnable = true;
            this.RtsEnable = true;
            this.ReadTimeout = 3000;
            this.DataReceived += PosProcessor_DataReceived;
        }

        private void PosProcessor_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort com = sender as SerialPort;
                int a = com.BytesToRead;
                byte[] buffer = new byte[a];
                com.Read(buffer, 0, a);
                MessageError = System.Text.Encoding.ASCII.GetString(buffer).EndsWith(RESULT_FORMAT) ? "Kết nối tới thiết bị IPOS thành công" : string.Format("Kết nối tới thiết bị IPOS thất bại. Vui lòng kiểm tra lại kết nối cổng {0}", this.PortName);
                Inventec.Common.Logging.LogSystem.Debug(MessageError + ": " + Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => System.Text.Encoding.ASCII.GetString(buffer)), System.Text.Encoding.ASCII.GetString(buffer)));
                if (delegateSend != null)
                    delegateSend(System.Text.Encoding.ASCII.GetString(buffer).EndsWith(RESULT_FORMAT), MessageError);
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }

        }

        public bool ConnectPort(ref string messageError)
        {
            try
            {
                this.Open();
                if (this.IsOpen)
                {
                    this.Send(null);
                    try
                    {
                        var key = this.ReadChar();//Kết nối đúng thiết bị sẽ không nhảy vào Exception
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Inventec.Common.Logging.LogSystem.Error(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
            messageError = string.Format("Kết nối tới thiết bị IPOS thất bại. Vui lòng kiểm tra lại kết nối cổng {0}", this.PortName);
            DisposePort();
            return false;
        }

        public void Send(string dataSend)
        {
            try
            {
                MessageError = null;
                if (this.IsOpen)
                {
                    dataSend = dataSend ?? "";
                    switch (typeSend)
                    {
                        case SendType.QR:
                            dataSend = string.Format("MF{0}", string.Format("{0:0000}", QR_LENGTH + dataSend.Length)) + "{" + string.Format(QR_FORMAT, dataSend) + "}" + "ED";
                            break;
                        case SendType.Text:
                            dataSend = string.Format("MF{0}", string.Format("{0:0000}", A_LENGTH + dataSend.Length)) + "{" + string.Format(A_FORMAT, dataSend) + "}" + "ED";
                            break;
                        default:
                            break;
                    }
                    this.Write(dataSend);
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void DisposePort()
        {

            try
            {
                if (this.IsOpen)
                {
                    this.Send(null);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }

        }
    }
}
