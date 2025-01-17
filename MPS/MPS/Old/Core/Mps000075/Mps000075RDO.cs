/* IVT
 * @Project : hisnguonmo
 * Copyright (C) 2017 INVENTEC
 *  
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 *  
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */
using MOS.EFMODEL.DataModels;
using MPS.ADO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS.Core.Mps000075
{
    /// <summary>
    /// In bang ke thanh toan ra vien ngoai tru va noi tru.
    /// </summary>
    public class Mps000075RDO : RDOBase
    {
        internal PatyAlterBhytADO PatyAlterBhyt { get; set; }

        internal string DepartmentName { get; set; }
        internal PatientADO Patient { get; set; }
        internal V_HIS_PATIENT_TYPE_ALTER PatientTypeAlter { get; set; }
        internal V_HIS_TREATMENT currentTreatment { get; set; }
        internal string ratio;
        internal List<MOS.EFMODEL.DataModels.V_HIS_DEPARTMENT_TRAN> departmentTrans { get; set; }
        MOS.EFMODEL.DataModels.V_HIS_TRAN_PATI hisTranPati { get; set; }
        List<MOS.EFMODEL.DataModels.V_HIS_TREATMENT_FEE> treatmentFees { get; set; }
        string currentDateSeparateFullTime = "";

        List<MOS.EFMODEL.DataModels.V_HIS_SERE_SERV> hisSereServ_Bordereaus;

        internal List<MPS.ADO.ServiceGroupPrintADO> highTechServiceReports { get; set; }
        internal List<V_HIS_SERE_SERV> highTechDepartments { get; set; }
        internal List<SereServADO> hightTechServices { get; set; }
        internal List<SereServADO> serviceInHightTechs { get; set; }

        internal List<ServiceGroupPrintADO> ListGroupServiceTypeADO { get; set; }
        internal List<SereServADO> departmentADOs { get; set; }
        internal List<SereServADO> sereServADOs { get; set; }

        public Mps000075RDO(
            PatientADO patient,
            PatyAlterBhytADO patyAlterBhyt,

            List<MOS.EFMODEL.DataModels.V_HIS_SERE_SERV> HisSereServ_Bordereaus,

            List<MPS.ADO.ServiceGroupPrintADO> HighTechServiceReports,
            List<SereServADO> HightTechServices,
            List<V_HIS_SERE_SERV> HighTechDepartments,
            List<SereServADO> ServiceInHightTechs,

            List<ServiceGroupPrintADO> ListGroupServiceTypeADO,
            List<SereServADO> Departments,
            List<SereServADO> SereServADOs,

            List<MOS.EFMODEL.DataModels.V_HIS_TREATMENT_FEE> treatmentFees,
            MOS.EFMODEL.DataModels.V_HIS_TRAN_PATI hisTranPati,
            List<MOS.EFMODEL.DataModels.V_HIS_DEPARTMENT_TRAN> departmentTrans
            )
        {
            try
            {
                this.Patient = patient;
                this.PatyAlterBhyt = patyAlterBhyt;

                this.hisSereServ_Bordereaus = HisSereServ_Bordereaus;

                this.highTechServiceReports = HighTechServiceReports;
                this.hightTechServices = HightTechServices;
                this.highTechDepartments = HighTechDepartments;
                this.serviceInHightTechs = ServiceInHightTechs;

                this.ListGroupServiceTypeADO = ListGroupServiceTypeADO;
                this.departmentADOs = Departments;
                this.sereServADOs = SereServADOs;

                this.treatmentFees = treatmentFees;
                this.hisTranPati = hisTranPati;
                this.departmentTrans = departmentTrans;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        internal override void SetSingleKey()
        {
            try
            {
                if (PatyAlterBhyt != null)
                {
                    if (PatyAlterBhyt.IS_HEIN != null)
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.IS_HEIN, "X"));
                    else
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.IS_NOT_HEIN, "X"));
                    if (PatyAlterBhyt.RIGHT_ROUTE_CODE == MOS.LibraryHein.Bhyt.HeinRightRoute.HeinRightRouteCode.TRUE)
                    {
                        if (PatyAlterBhyt.RIGHT_ROUTE_TYPE_CODE == MOS.LibraryHein.Bhyt.HeinRightRouteType.HeinRightRouteTypeCode.EMERGENCY)// la dung tuyen cap cuu
                        {
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME_CC, "X"));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME, ""));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.NOT_RIGHT_ROUTE_TYPE_NAME, ""));
                        }
                        else if (PatyAlterBhyt.RIGHT_ROUTE_TYPE_CODE == MOS.LibraryHein.Bhyt.HeinRightRouteType.HeinRightRouteTypeCode.PRESENT)// la dung tuyen: gioi thieu,
                        {
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME_CC, ""));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME, "X"));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.NOT_RIGHT_ROUTE_TYPE_NAME, ""));
                        }
                        else
                        {
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME_CC, ""));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME, "X"));
                            keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.NOT_RIGHT_ROUTE_TYPE_NAME, ""));
                        }
                    }
                    else if (PatyAlterBhyt.RIGHT_ROUTE_CODE == MOS.LibraryHein.Bhyt.HeinRightRoute.HeinRightRouteCode.FALSE)//trai tuyen
                    {
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME_CC, ""));
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RIGHT_ROUTE_TYPE_NAME, ""));
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.NOT_RIGHT_ROUTE_TYPE_NAME, "X"));
                    }
                }
                else
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.IS_NOT_HEIN, "X"));

                if (currentTreatment != null)
                {
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.ICD_MAIN_CODE, currentTreatment.ICD_CODE));
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.ICD_MAIN_TEXT, currentTreatment.ICD_NAME));
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.RATIO, ratio));
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TREATMENT_CODE, currentTreatment.TREATMENT_CODE));
                }

                if (departmentTrans != null && departmentTrans.Count > 0)
                {
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.OPEN_TIME_SEPARATE_STR, Inventec.Common.DateTime.Convert.TimeNumberToTimeString(departmentTrans[0].LOG_TIME)));
                    if (departmentTrans[departmentTrans.Count - 1] != null)
                    {
                        keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.CLOSE_TIME_SEPARATE_STR, Inventec.Common.DateTime.Convert.TimeNumberToTimeString(departmentTrans[departmentTrans.Count - 1].LOG_TIME)));
                    }
                }

                if (hisTranPati != null)
                {
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TRAN_PATI_MEDI_ORG_CODE, hisTranPati.MEDI_ORG_CODE));
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TRAN_PATI_MEDI_ORG_NAME, hisTranPati.MEDI_ORG_NAME));
                }

                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.CURRENT_DATE_SEPARATE_FULL_STR, currentDateSeparateFullTime));


                decimal thanhtien_tong = 0;
                decimal bhytthanhtoan_tong = 0;
                decimal nguonkhac_tong = 0;
                decimal bnthanhtoan_tong = 0;

                if (hisSereServ_Bordereaus != null && hisSereServ_Bordereaus.Count > 0)
                {
                    thanhtien_tong = hisSereServ_Bordereaus.Sum(o => (o.VIR_TOTAL_PRICE ?? 0));
                    bhytthanhtoan_tong = hisSereServ_Bordereaus.Sum(o => (o.VIR_TOTAL_HEIN_PRICE ?? 0));
                    bnthanhtoan_tong = hisSereServ_Bordereaus.Sum(o => (o.VIR_TOTAL_PATIENT_PRICE ?? 0));
                    nguonkhac_tong = 0;
                }

                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE, Inventec.Common.Number.Convert.NumberToStringRoundAuto(thanhtien_tong, 0)));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_HEIN, Inventec.Common.Number.Convert.NumberToStringRoundAuto(bhytthanhtoan_tong, 0)));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_PATIENT, Inventec.Common.Number.Convert.NumberToStringRoundAuto(bnthanhtoan_tong, 0)));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_OTHER, Inventec.Common.Number.Convert.NumberToStringRoundAuto(nguonkhac_tong, 0)));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_TEXT, Inventec.Common.String.Convert.CurrencyToVneseString(Math.Round(thanhtien_tong).ToString())));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_HEIN_TEXT, Inventec.Common.String.Convert.CurrencyToVneseString(Math.Round(bhytthanhtoan_tong).ToString())));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_PATIENT_TEXT, Inventec.Common.String.Convert.CurrencyToVneseString(Math.Round(bnthanhtoan_tong).ToString())));
                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_PRICE_OTHER_TEXT, Inventec.Common.String.Convert.CurrencyToVneseString(Math.Round(nguonkhac_tong).ToString())));

                if (treatmentFees != null)
                {
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_DEPOSIT_AMOUNT, Inventec.Common.Number.Convert.NumberToStringRoundAuto(treatmentFees[0].TOTAL_DEPOSIT_AMOUNT ?? 0, 0)));
                }
                else
                {
                    keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.TOTAL_DEPOSIT_AMOUNT, "0"));
                }

                keyValues.Add(new KeyValue(Mps000075ExtendSingleKey.CREATOR_USERNAME, Inventec.UC.Login.Base.ClientTokenManagerStore.ClientTokenManager.GetUserName()));

                GlobalQuery.AddObjectKeyIntoListkey<PatientADO>(Patient, keyValues);
                GlobalQuery.AddObjectKeyIntoListkey<PatyAlterBhytADO>(PatyAlterBhyt, keyValues, false);

            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }


    }
}
