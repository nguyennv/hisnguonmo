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
using MPS.ProcessorBase.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS.Processor.Mps000028.PDO
{
    public partial class Mps000028PDO : RDOBase
    {
        public V_HIS_SERVICE_REQ ServiceReqPrint { get; set; }
        public V_HIS_PATIENT_TYPE_ALTER PatyAlterBhyt { get; set; }
        public HIS_TREATMENT currentHisTreatment { get; set; }
        //public List<V_HIS_SERE_SERV> sereServs { get; set; }
        public List<SereServADO> sereServADOs { get; set; }
        public V_HIS_BED_LOG BedLog { get; set; }
        public Mps000028ADO Mps000028ADO { get; set; }
        public HIS_DHST _HIS_DHST { get; set; }
        public HIS_WORK_PLACE _HIS_WORK_PLACE { get; set; }
    }

    public class SereServADO : V_HIS_SERE_SERV
    {
        public decimal? VIR_TOTAL_HEIN_PRICE_SUM { get; set; }
        public decimal? VIR_TOTAL_PATIENT_PRICE_SUM { get; set; }
        public decimal? VIR_TOTAL_PRICE_SUM { get; set; }
        public decimal? VIR_TOTAL_PRICE_NO_EXPEND_SUM { get; set; }
        public decimal? PRICE_BHYT { get; set; }
        public long? SERVICE_PACKAGE_ID { get; set; }
        public string DEPARTMENT__SERVICE_GROUP__ID { get; set; }
        public string REQUEST_LOGINNAME { get; set; }
        public string REQUEST_USERNAME { get; set; }
        public string SERVICE_CODE { get; set; }
        public string SERVICE_NAME { get; set; }
        public long? SERVICE_NUM_ORDER { get; set; }


        public string CONCLUDE { get; set; }
        public long? BEGIN_TIME { get; set; }
        public long? END_TIME { get; set; }
        public string INSTRUCTION_NOTE { get; set; }
        public string NOTE { get; set; }
        public decimal? ESTIMATE_DURATION { get; set; }

        public string patientIdQr { get; set; }
        public byte[] bPatientQr { get; set; }

        public string patientNameQr { get; set; }
        public byte[] bPatientNameQr { get; set; }

        public string studyDescriptionQr { get; set; }
        public byte[] bStudyDescriptionQr { get; set; }

        public byte[] ServiceReqExecuteQr { get; set; }

        public byte[] QrDiimV2 { get; set; }

        public string PREVIEW_BARCODE { get; set; }
        public byte[] BARCODE { get; set; }

        public string SERVICE_CONDITION_CODE { get; set; }
        public string SERVICE_CONDITION_NAME { get; set; }

        public SereServADO() { }

        public SereServADO(V_HIS_SERE_SERV data)
        {
            try
            {
                System.Reflection.PropertyInfo[] pi = Inventec.Common.Repository.Properties.Get<V_HIS_SERE_SERV>();
                foreach (var item in pi)
                {
                    item.SetValue(this, (item.GetValue(data)));
                }
                this.REQUEST_LOGINNAME = data.TDL_REQUEST_LOGINNAME;
                this.REQUEST_USERNAME = data.TDL_REQUEST_USERNAME;
                this.SERVICE_CODE = data.TDL_SERVICE_CODE;
                this.SERVICE_NAME = data.TDL_SERVICE_NAME;

                VIR_TOTAL_PRICE_NO_EXPEND_SUM = null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }

        public SereServADO(V_HIS_SERE_SERV_11 data)
        {
            try
            {
                Inventec.Common.Mapper.DataObjectMapper.Map<V_HIS_SERE_SERV>(this, data);

                this.REQUEST_LOGINNAME = data.TDL_REQUEST_LOGINNAME;
                this.REQUEST_USERNAME = data.TDL_REQUEST_USERNAME;
                this.SERVICE_CODE = data.TDL_SERVICE_CODE;
                this.SERVICE_NAME = data.TDL_SERVICE_NAME;

                VIR_TOTAL_PRICE_NO_EXPEND_SUM = null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Warn(ex);
            }
        }
    }

    public class Mps000028ADO
    {
        public string bebRoomName { get; set; }
        public string firstExamRoomName { get; set; }
        public decimal ratio { get; set; }
        public long PatientTypeId__Bhyt { get; set; }
        public string TITLE { get; set; }
        public string PARENT_NAME { get; set; }
        public long? CURRENT_EXECUTE_ROOM_NUM_ORDER { get; set; }
        public string REQUEST_USER_MOBILE { get; set; }
    }
}
