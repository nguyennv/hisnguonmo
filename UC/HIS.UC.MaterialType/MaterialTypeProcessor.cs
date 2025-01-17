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
using HIS.UC.MaterialType.ADO;
using HIS.UC.MaterialType.Focus;
using HIS.UC.MaterialType.GetData;
using HIS.UC.MaterialType.GetListCheck;
using HIS.UC.MaterialType.New;
using HIS.UC.MaterialType.Reload;
using HIS.UC.MaterialType.ResetKeyWord;
using HIS.UC.MaterialType.Run;
using HIS.UC.MaterialType.EnableSave;
using HIS.UC.MaterialType.Search;
using Inventec.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.UC.MaterialType.EnableBid;
using HIS.UC.MaterialType.GetBidId;
using HIS.UC.MaterialType.SetEditValueBid;
using HIS.UC.MaterialType.GetBidEnable;
using HIS.UC.MaterialType.ReloadBid;
using HIS.UC.MaterialType.ReloadMatiBid;
using HIS.UC.MaterialType.EnableContract;
using HIS.UC.MaterialType.ReloadContract;
using HIS.UC.MaterialType.SetEditValueContract;
using HIS.UC.MaterialType.GetContractEnable;
using HIS.UC.MaterialType.GetContractId;
using HIS.UC.MaterialType.FocusContract;
using HIS.UC.MaterialType.GetStatusChkGroupByMap;

namespace HIS.UC.MaterialType
{
    public class MaterialTypeTreeProcessor : BussinessBase
    {
        object uc;
        public MaterialTypeTreeProcessor()
            : base()
        {
        }

        public MaterialTypeTreeProcessor(CommonParam paramBusiness)
            : base(paramBusiness)
        {
        }

        public object Run(MaterialTypeInitADO arg)
        {
            uc = null;
            try
            {
                IRun behavior = RunFactory.MakeIMaterialType(param, arg);
                uc = behavior != null ? (behavior.Run()) : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                uc = null;
            }
            return uc;
        }

        public void Search(UserControl control)
        {
            try
            {
                ISearch behavior = SearchFactory.MakeISearch(param, (control == null ? (UserControl)uc : control));
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void EnableSaveButton(UserControl control, bool _enable)
        {
            try
            {
                IEnableSave behavior = EnableSaveFactory.MakeIEnableSave((control == null ? (UserControl)uc : control), _enable);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void EnableBid(UserControl control, bool _enable)
        {
            try
            {
                IEnableBid behavior = EnableBidFactory.MakeIEnableBid((control == null ? (UserControl)uc : control), _enable);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void EnableContract(UserControl control, bool _enable)
        {
            try
            {
                IEnableContract behavior = EnableContractFactory.MakeIEnableContract((control == null ? (UserControl)uc : control), _enable);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void Reload(UserControl control, List<MOS.EFMODEL.DataModels.V_HIS_MATERIAL_TYPE> MaterialTypes)
        {
            try
            {
                IReload behavior = ReloadFactory.MakeIReload(param, (control == null ? (UserControl)uc : control), MaterialTypes);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }
        public void Reload(UserControl control, List<MaterialTypeADO> MaterialTypes)
        {
            try
            {
                IReloadMatiBid behavior = ReloadMatiBidFactory.MakeIReload(param, (control == null ? (UserControl)uc : control), MaterialTypes);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void ReloadBid(UserControl control, List<MOS.EFMODEL.DataModels.V_HIS_BID_1> bids)
        {
            try
            {
                IReloadBid behavior = ReloadBidFactory.MakeIReloadBid(param, (control == null ? (UserControl)uc : control), bids);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void ReloadContract(UserControl control, List<MOS.EFMODEL.DataModels.HIS_MEDICAL_CONTRACT> Contracts)
        {
            try
            {
                IReloadContract behavior = ReloadContractFactory.MakeIReloadContract(param, (control == null ? (UserControl)uc : control), Contracts);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public object GetData(UserControl control)
        {
            object result = null;
            //object uc = null;
            try
            {
                IGetData behavior = GetDataFactory.MakeIGetData(param, (control == null ? (UserControl)uc : control));
                result = (behavior != null) ? behavior.Run() : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
            return result;
        }

        public void New(UserControl control)
        {
            try
            {
                INew behavior = NewFactory.MakeINew(param, (control == null ? (UserControl)uc : control));
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void SetEditValueBid(UserControl control, long? _bidId)
        {
            try
            {
                ISetEditValueBid behavior = SetEditValueBidFactory.MakeISetEditValueBid((control == null ? (UserControl)uc : control), _bidId);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void SetEditValueContract(UserControl control, long? _contractId)
        {
            try
            {
                ISetEditValueContract behavior = SetEditValueContractFactory.MakeISetEditValueContract((control == null ? (UserControl)uc : control), _contractId);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public bool GetBidEnable(UserControl control)
        {
            bool result = false;
            try
            {
                IGetBidEnable behavior = GetBidEnableFactory.MakeIGetBidEnable(control);
                result = (behavior != null) ? behavior.Run() : false;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = false;
            }
            return result;
        }

        public bool GetContractEnable(UserControl control)
        {
            bool result = false;
            try
            {
                IGetContractEnable behavior = GetContractEnableFactory.MakeIGetContractEnable(control);
                result = (behavior != null) ? behavior.Run() : false;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = false;
            }
            return result;
        }

        public long? GetBid(UserControl control)
        {
            long? result = null;
            try
            {
                IGetBidId behavior = GetBidIdFactory.MakeIGetBidId(control);
                result = (behavior != null) ? behavior.Run() : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = null;
            }
            return result;
        }

        public long? GetContract(UserControl control)
        {
            long? result = null;
            try
            {
                IGetContractId behavior = GetContractIdFactory.MakeIGetContractId(control);
                result = (behavior != null) ? behavior.Run() : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = null;
            }
            return result;
        }

        public List<MaterialTypeADO> GetListCheck(UserControl control)
        {
            List<MaterialTypeADO> result = null;
            try
            {
                IGetListCheck behavior = GetListCheckFactory.MakeIGetListCheck(control);
                result = (behavior != null) ? behavior.Run() : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = null;
            }
            return result;
        }

        public void FocusKeyword(UserControl uc)
        {
            try
            {
                IFocus behavior = FocusFactory.MakeIFocus(uc, false);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void ResetKeyword(UserControl uc)
        {
            try
            {
                IResetKeyWord behavior = ResetKeyWordFactory.MakeIResetKeyWord(uc);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public object GetDataFocus(UserControl control)
        {
            object result = null;
            try
            {
                IGetData behavior = GetDataFactory.MakeIGetData(param, (control == null ? (UserControl)uc : control));
                result = (behavior != null) ? behavior.Run() : null;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
            return result;
        }

        public void FocusBid(UserControl uc)
        {
            try
            {
                IFocus behavior = FocusFactory.MakeIFocus(uc, true);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public void FocusContract(UserControl uc)
        {
            try
            {
                IFocusContract behavior = FocusContractFactory.MakeIFocusContract(uc, true);
                if (behavior != null) behavior.Run();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        public bool GetStatusChkGroupByMap(UserControl control)
        {
            bool result = false;
            try
            {
                IGetStatusChkGroupByMap behavior = GetStatusChkGroupByMapFactory.MakeIGetStatusChkGroupByMap(control);
                result = (behavior != null) ? behavior.Run() : false;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = false;
            }
            return result;
        }

        
    }
}
