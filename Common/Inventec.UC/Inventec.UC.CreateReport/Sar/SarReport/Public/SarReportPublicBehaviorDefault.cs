﻿using Inventec.Core;
using Inventec.UC.CreateReport.Base;
using Inventec.UC.CreateReport.MessageLang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.UC.CreateReport.Sar.SarReport.Public
{
    class SarReportPublicBehaviorDefault : Inventec.UC.CreateReport.Base.BusinessBase, ISarReportPublic
    {
        internal SarReportPublicBehaviorDefault(CommonParam paramPublic, SAR.EFMODEL.DataModels.SAR_REPORT data)
            : base(paramPublic)
        {
            Data = data;
        }

        private SAR.EFMODEL.DataModels.SAR_REPORT Data { get; set; }

        public SAR.EFMODEL.DataModels.SAR_REPORT Public()
        {
            SAR.EFMODEL.DataModels.SAR_REPORT result = null;

            #region logging input data
            try
            {
                TokenCheck(); Input = Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => Data), Data) + Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => param), param);
            }
            catch { }
            #endregion
            try
            {
                var rs = Base.ApiConsumerStore.SarConsumer.Post<Inventec.Core.ApiResultObject<SAR.EFMODEL.DataModels.SAR_REPORT>>("/api/SarReport/Public", param, Data);
                if (rs != null)
                {
                    param = rs.Param != null ? rs.Param : param;
                    result = rs.Data;
                }
            }
            catch (Inventec.Common.WebApiClient.ApiException ex)
            {
                param.HasException = true;
                Logging("Co loi khi goi api: " + Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => ex.StatusCode), ex.StatusCode), LogType.Info);
                if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageUtil.SetMessage(param, Message.Enum.PhanMemKhongKetNoiDuocToiMayChuHeThong);
                }
                else if (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageUtil.SetMessage(param, Message.Enum.HeThongTBNguoiDungDaHetPhienLamViecVuiLongDangNhapLai);
                }
                else if (ex.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageUtil.SetMessage(param, Message.Enum.HeThongTBBanQuyenKhongHopLe);
                }
            }
            catch (AggregateException ex)
            {
                param.HasException = true;
                Inventec.Common.Logging.LogSystem.Error(ex);
                MessageUtil.SetMessage(param, Message.Enum.PhanMemKhongKetNoiDuocToiMayChuHeThong);
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                //BugUtil.SetBugCode(param, Bug.Enum.CoLoiXayRa);
                result = null;
            }

            #region logging system data
            try
            {
                MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                if (param.HasException) { LogInOut(); }
            }
            catch { }
            #endregion
            return result;
        }
    }
}