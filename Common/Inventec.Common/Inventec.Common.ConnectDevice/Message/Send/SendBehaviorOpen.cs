﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.Common.ConnectDevice.Message.Send
{
    class SendBehaviorOpen : ISend
    {
        void ISend.Run(ConnectToDevice connectDevice)
        {
            try
            {
                connectDevice.connectStore.isConnecting = false;
                connectDevice.connectStore.messageIdOpen = GenerateMessageId.Generate("Open");
                string sendMessage = new StringBuilder().Append(connectDevice.connectStore.messageIdOpen).Append(Store.ConnectConstant.MESSAGE_SEPARATOR).Append(Store.ConnectConstant.MESSAGE_OPEN).Append(Store.ConnectConstant.MESSAGE_SEPARATOR).Append(connectDevice.connectStore.APPCODE).ToString();
                int? checksum = Inventec.Common.Checksum.Rs232.Calc(sendMessage);
                if (checksum.HasValue)
                {
                    string message = new StringBuilder().Append(checksum.Value).Append(Store.ConnectConstant.MESSAGE_SEPARATOR).Append(sendMessage).ToString();
                    connectDevice.Send(message, true, true);
                }
                else
                {
                    Inventec.Common.Logging.LogSystem.Info("Tinh check sum cho ban tin that bai: " + Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => checksum), checksum));
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }
    }
}