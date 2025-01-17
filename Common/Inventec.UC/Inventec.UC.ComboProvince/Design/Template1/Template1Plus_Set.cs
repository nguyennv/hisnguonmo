﻿using Inventec.UC.ComboProvince.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventec.UC.ComboProvince.Design.Template1
{
    internal partial class Template1
    {
        #region Set Delegate
        internal bool SetDelegateLoadDistrict(LoadComboDistrictFromProvince Load)
        {
            bool result = false;
            try
            {
                this._LoadHuyenFromTinh = Load;
                if (_LoadHuyenFromTinh != null)
                {
                    result = true;
                }
                else
                {
                    Inventec.Common.Logging.LogSystem.Debug(Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => Load), Load));
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = false;
            }
            return result;
        }

        internal bool SetDelegateSetValue(SetValueCboDistrictAndCboCommune setValue)
        {
            bool result = false;
            try
            {
                this._SetValue = setValue;
                if (_SetValue != null)
                {
                    result = true;
                }
                else
                {
                    Inventec.Common.Logging.LogSystem.Debug(Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => setValue), setValue));
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
            return result;
        }

        internal bool SetDelegateFocusDistrict(SetFocusCboDistrict focus)
        {
            bool result = false;
            try
            {
                this._FocusCboHuyen = focus;
                if (_FocusCboHuyen != null)
                {
                    result = true;
                }
                else
                {
                    Inventec.Common.Logging.LogSystem.Debug(Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => focus), focus));
                }
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
                result = false;
            }
            return result;
        } 
        #endregion

        internal void SetFocus()
        {
            try
            {
                txtMaTinh.Focus();
                txtMaTinh.SelectAll();
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }

        }

        internal void SetTextLabel(string text)
        {
            try
            {
                lblTinh.Text = text;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        internal void SetValueComboTinh(string ProvinceCODE)
        {
            try
            {
                cboTinh.EditValue = ProvinceCODE;
                txtMaTinh.Text = ProvinceCODE;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        internal void SetDataInit(DataInitProcinve Data)
        {
            try
            {
                this.Data = Data;
                Inventec.Common.Logging.LogSystem.Debug(Inventec.Common.Logging.LogUtil.TraceData(Inventec.Common.Logging.LogUtil.GetMemberName(() => Data), Data));
                //this.listData = Data.listProvince;
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }

        internal void ResetValue()
        {
            try
            {
                cboTinh.EditValue = null;
                txtMaTinh.Text = "";
            }
            catch (Exception ex)
            {
                Inventec.Common.Logging.LogSystem.Error(ex);
            }
        }
    }
}
